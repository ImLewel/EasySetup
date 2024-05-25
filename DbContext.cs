using Microsoft.Data.Sqlite;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasySetup
{
  internal class DbContext
  {
    private SqliteConnection _connection;

    internal DbContext(string dbPath) 
    { 
      _connection = new SqliteConnection($"Data source={dbPath}");
      _connection.Open();
    }

    public async void Append(string table, params string[] values)
    {
      var preparedValues = values.Prepend("NULL").ToList();
      string query = $"INSERT INTO {table} VALUES ${Tuple.Create(preparedValues.Select(item => "?"))}";
      SqliteCommand cmd = new SqliteCommand(query, _connection);
      foreach ( var value in preparedValues)
      {
        cmd.Parameters.Add(value);
      }
      cmd.Connection = _connection;
      await cmd.ExecuteNonQueryAsync();
    }

    public async void Remove(string table, string columnName, string comparable)
    {
      string query = $"DELTE FROM {table} WHERE {columnName}=?";
      SqliteCommand cmd = new SqliteCommand(query, _connection);
      cmd.Parameters.Add(comparable);
      await cmd.ExecuteNonQueryAsync();
    }

    public async Task<SqliteDataReader> RetrieveColumn(string table, string columnName)
    {
      string query = $"SELECT {columnName} FROM {table}";
      return await Retrieve(query);
    }

    private async Task<SqliteDataReader> Retrieve(string query)
    {
      SqliteCommand cmd = new SqliteCommand(query, _connection);
      return await cmd.ExecuteReaderAsync();
    }
  }
}
