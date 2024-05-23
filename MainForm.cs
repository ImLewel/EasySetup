using Microsoft.Data.Sqlite;
using System.Diagnostics;

namespace EasySetup
{
  public partial class MainForm : Form
  {
    SqliteConnection con;
    string dbFile = "data.db";
    string downloadPath = @"Downloaded\";
    static readonly HttpClient client = new HttpClient();

    public MainForm()
    {
      InitializeComponent();
      con = new SqliteConnection($"Data source={dbFile}");
      con.Open();
      FillData();
    }

    public void FillData()
    {
      var checkedListBoxes = GetAll(this, typeof(CheckedListBox));
      foreach (var checkedListBox in checkedListBoxes)
      {
        //Get name of each CheckedBoxList and insert values from respective table with Name column values
        string query = $"SELECT Name FROM {checkedListBox.Name}";
        SqliteCommand command = new SqliteCommand(query, con);
        var result = command.ExecuteReader();
        var clb = (CheckedListBox)checkedListBox;
        if (result.HasRows)
        {
          while (result.Read())
          {
            clb.Items.Add(result.GetValue(0));
          }
          clb.Height = (clb.Items.Count + 1) * clb.GetItemRectangle(0).Height;
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

    private async Task Install(string url, string name)
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
        //For future purpose: ability to specify some arguments
        //of installation (silent, verbose, etc)
        string args = String.Empty;
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
      var checkedListBoxes = GetAll(this, typeof(CheckedListBox));
      foreach (var checkedListBox in checkedListBoxes)
      {
        var clb = (CheckedListBox)checkedListBox;
        foreach (var checkBox in clb.CheckedItems)
        {
          string query = $"SELECT Link FROM {checkedListBox.Name} WHERE Name=@name";
          using (SqliteCommand command = new SqliteCommand(query, con))
          {
            command.Parameters.AddWithValue("@name", checkBox.ToString());
            using (var result = command.ExecuteReader())
            {
              if (result.Read())
              {
                string link = result.GetString(0);
                Install(link, checkBox.ToString());
              }
            }
          }
        }
      }
    }

  }
}