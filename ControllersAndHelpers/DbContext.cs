using Microsoft.Data.Sqlite;

namespace EasySetup.ControllersAndHelpers
{
    internal class DbContext
    {
        private SqliteConnection _connection;

        internal DbContext(string dbPath)
        {
            _connection = new SqliteConnection($"Data source={dbPath}");
            _connection.Open();
        }

        public List<string> GetColumnHeaders(string table)
        {
            List<string> result = new();
            string query = $"PRAGMA table_info({table})";
            using (SqliteCommand cmd = new SqliteCommand(query, _connection))
            {
                var dr = cmd.ExecuteReader();
                while (dr.Read())//loop through the various columns and their info
                {
                    var value = dr.GetValue(1);//column 1 from the result contains the column names
                    result.Add(value.ToString());
                }
                return result;
            }
        }

        public async void Append(string table, params string[] values)
        {
            //Get table columns
            var columns = GetColumnHeaders(table).Where(item => item != "Id");
            //Make a parameter names from values
            var paramNames = columns.Select(item => $"@{item}Param").ToArray();
            //Create query placeholders
            string columnPlaceHolder = string.Join(",", columns);
            string paramPlaceHolder = string.Join(",", paramNames);

            string query = $"INSERT INTO {table} ({columnPlaceHolder}) VALUES ({paramPlaceHolder})";
            using (SqliteCommand cmd = new SqliteCommand(query, _connection))
            {
                for (int i = 0; i < paramNames.Length; i++)
                {
                    var paramName = paramNames[i];
                    var value = values[i];
                    cmd.Parameters.AddWithValue(paramName, value);
                }
                await cmd.ExecuteNonQueryAsync();
            }
        }

        public async void Remove(string table, string columnName, string comparable)
        {
            string columnPlaceHolder = $"@{columnName}Param";
            string query = $"DELETE FROM {table} WHERE {columnName}={columnPlaceHolder}";
            using (SqliteCommand cmd = new SqliteCommand(query, _connection))
            {
                cmd.Parameters.AddWithValue(columnPlaceHolder, comparable);
                await cmd.ExecuteNonQueryAsync();
            }
        }

        public async Task<SqliteDataReader> RetrieveColumn(string table, string columnName)
        {
            string query = $"SELECT {columnName} FROM {table}";
            return await Retrieve(query);
        }

        public async Task<SqliteDataReader> RetrieveColumnWhere(string table, string requiredColumn, string columnName, string comparable)
        {
            string columnPlaceHolder = $"@{columnName}Param";
            string query = $"SELECT {requiredColumn} FROM {table} WHERE {columnName}={columnPlaceHolder}";
            return await Retrieve(
              query,
              new List<string>() { columnPlaceHolder },
              new List<string>() { comparable }
            );
        }

        private async Task<SqliteDataReader> Retrieve(string query)
        {
            SqliteCommand cmd = new SqliteCommand(query, _connection);
            return await cmd.ExecuteReaderAsync();
        }

        private async Task<SqliteDataReader> Retrieve(string query, List<string> paramNames, List<string> values)
        {
            SqliteCommand cmd = new SqliteCommand(query, _connection);
            for (int i = 0; i < paramNames.Count; i++)
            {
                cmd.Parameters.AddWithValue(paramNames[i], values[i]);
            }
            return await cmd.ExecuteReaderAsync();
        }
    }
}
