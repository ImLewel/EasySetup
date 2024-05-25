using EasySetup.ControllersAndHelpers;
using Microsoft.Data.Sqlite;
using System.Diagnostics;
using System.Security.Permissions;

namespace EasySetup
{
    public partial class MainForm : Form
  {
    DbContext dbContext;
    string dbFile = "data.db";
    string downloadPath = @"Downloaded\";
    static readonly HttpClient client = new HttpClient();

    public MainForm()
    {
      InitializeComponent();
      dbContext = new DbContext(dbFile);
      FillData();
    }

    public async void FillData()
    {
      var categoryBoxes = GetAll(this, typeof(CategoryBox));
      foreach (var categoryBox in categoryBoxes)
      {
        //Get name of each CheckedBoxList and insert values from respective table with Name column values
        CategoryBox cb = (CategoryBox)categoryBox;
        cb.SetConnection(dbContext);
        SqliteDataReader result = await dbContext.RetrieveColumn(cb.SQLiteTableBinding, "Name");
        if (result.HasRows)
        {
          while (result.Read())
          {
            cb.AddRowWithName(result.GetValue(0).ToString());
          }
        }
      }
    }



    public IEnumerable<Control> GetAll(Control control, Type type)
    {
      var controls = control.Controls.Cast<Control>();

      return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                .Concat(controls)
                                .Where(c => c.GetType() == type);
    }

    private void Caption_Click(object sender, EventArgs e)
    {
      Process.Start(
        new ProcessStartInfo
        {
          FileName = "https://github.com/ImLewel",
          UseShellExecute = true
        }
      );
    }

    private async Task Download(Uri path, string outputName)
    {
      using (var stream = await client.GetStreamAsync(path))
      {
        using (var fs = new FileStream(outputName, FileMode.CreateNew))
        {
          await stream.CopyToAsync(fs);
          fs.Close();
        }
        stream.Close();
      }

    }

    private async Task Install(string url, string name, string mode)
    {
      //Make sure we have download directory
      Directory.CreateDirectory(downloadPath);
      //Get URI from URL
      Uri path = new Uri(url);
      //Get extension of the file
      string ext = Path.GetExtension(path.AbsolutePath);
      if (ext is null || ext == String.Empty)
      {
        ext = ".exe";
      }

      string storedFile = downloadPath + name + ext;

      //Make sure we won't install or download the same file again
      if (!File.Exists(storedFile))
      {
        await Download(path, storedFile);
        string args = (ext == ".exe" ? "/NORESTART" : "/norestart") +
          mode switch
          {
            "N" => String.Empty,
            "Q" => ext == ".exe" ? " /S" : " /quiet",
            "M" => ext == ".exe" ? " /SP" : " /passive",
          };
        try
        {
          Process installProcess = new Process
          {
            StartInfo = new ProcessStartInfo
            {
              FileName = storedFile,
              //Arguments = args,
              UseShellExecute = true
            }
          };
          installProcess.Start();
          await Task.Run(() => installProcess.WaitForExit());
        }
        catch
        {
          MessageBox.Show($"Something went wrong with {name} setup process");
        }
      }
    }

    private async void ConfirmButton_Click(object sender, EventArgs e)
    {
      var categoryBoxes = GetAll(this, typeof(CategoryBox));
      foreach (var categoryBox in categoryBoxes)
      {
        //Get name of each CheckedBoxList and insert values from respective table with Name column values
        CategoryBox cb = (CategoryBox)categoryBox;
        foreach (DataGridViewRow row in cb.tableContainer.Rows)
        {
          if (row.Cells["selectionColumn"].Value is true)
          {
            var name = row.Cells["nameColumn"].Value.ToString();
            using
            (
              SqliteDataReader result = await dbContext.RetrieveColumnWhere(
              cb.SQLiteTableBinding,
                "Link",
                "Name",
                name
              )
            )
            {
              if (result.Read())
              {
                string link = result.GetString(0);
                await Install(link, name, cb.GetSelection());
              }
            }
          }
        }
      }
    }
  }
}