using Microsoft.Data.Sqlite;
using System.ComponentModel;

namespace EasySetup
{
  public partial class CategoryBox : UserControl
  {
    private string _tableName;
    private string _insertName;
    private string _insertLink;
    private DbContext _dbContext;
    private string _selection = "N";

    public CategoryBox()
    {
      InitializeComponent();
    }

    [
      Browsable(true),
      Description("Sets the caption of this control (sets text into label under table)")
    ]
    public string Title
    {
      get => labelName.Text;
      set
      {
        labelName.Text = value;
      }
    }

    [
      Browsable(true),
      Description("Set name of table to be searched in the database context")
    ]
    public string SQLiteTableBinding
    {
      get => _tableName;
      set
      {
        _tableName = value;
      }
    }

    [
      Browsable(true),
      Description("Occurs when user press green plus button")
    ]
    private void addBtn_Click(object sender, EventArgs e)
    {
      AddRowDialog addRowDialog = new AddRowDialog();
      addRowDialog.WorkCompleted += receiveData;
      if (addRowDialog.ShowDialog() == DialogResult.OK)
      {
        //Insert row
        int index = tableContainer.Rows.Add();
        InitializeCheckBoxes(index);
        tableContainer.Rows[index].Cells["nameColumn"].Value = _insertName;
        tableContainer.Rows[index].Cells["normalMode"].Value = true;

        //Send data to DB
        _dbContext.Append(this.SQLiteTableBinding, _insertName, _insertLink);

        //Adjust the size of table
        tableContainer.Height += tableContainer.Rows[0].Height;
      }
    }

    private void InitializeCheckBoxes(int rowIndex)
    {
      for (int i = 0; i < tableContainer.Rows[rowIndex].Cells.Count; i++)
      {
        var cell = tableContainer.Rows[rowIndex].Cells[i];
        if (i > 0 && cell is DataGridViewCheckBoxCell)
        {
          cell.Value = false;
        }
      }
    }

    internal void AddRowWithName(string nameColumnValue)
    {
      //Insert row
      int index = tableContainer.Rows.Add();
      InitializeCheckBoxes(index);
      tableContainer.Rows[index].Cells["nameColumn"].Value = nameColumnValue;
      tableContainer.Rows[index].Cells["normalMode"].Value = true;

      //Adjust the size of table
      tableContainer.Height += tableContainer.Rows[0].Height;
    }

    private void receiveData(object sender, EventArgs e)
    {
      AddRowDialogEventArgs args = e as AddRowDialogEventArgs;
      _insertName = args.Name;
      _insertLink = args.Link;
    }

    internal void SetConnection(DbContext context) => _dbContext = context;

    [
      Browsable(true),
      Description("Occurs when user press blue D button")
    ]
    private void deleteButton_Click(object sender, EventArgs e)
    {
      this.Dispose();
    }

    [
      Browsable(true),
      Description("Occurs when user press red minus button")
    ]
    private void removeBtn_Click(object sender, EventArgs e)
    {
      if (tableContainer.Rows.Count > 0)
      {
        //Retrieve row index of currently selected cell
        int rowIndex = tableContainer.CurrentCell.RowIndex;
        //Remove data from DB
        _dbContext.Remove(this.SQLiteTableBinding, "Name", tableContainer.Rows[rowIndex].Cells["nameColumn"].Value.ToString());
        //Reduce the size of table
        tableContainer.Height -= tableContainer.Rows[0].Height;
        //Remove row from table
        tableContainer.Rows.RemoveAt(rowIndex);
      }
      else
        MessageBox.Show("Table contains no elements!", "Information");
    }

    [
      Browsable(true),
      Description("Occurs when user press yellow pencil button")
    ]
    private void editBtn_Click(object sender, EventArgs e)
    {
      //TBA
    }

    internal string GetSelection() => _selection;

    //Goofy ahh block of code but I can't get how to make it look better
    private void tableContainer_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      int rowIndex = e.RowIndex;
      int columnIndex = e.ColumnIndex;

      var cell = tableContainer.Rows[rowIndex].Cells[columnIndex];
      if (cell is DataGridViewCheckBoxCell && cell != tableContainer.Rows[rowIndex].Cells["selectionColumn"])
      {
        if (cell.Value is (object)false)
        {
          InitializeCheckBoxes(rowIndex);
          cell.Value = true;
          _selection = tableContainer.Columns[columnIndex].HeaderText;
        }
        else
        {
          MessageBox.Show("Selection can't be empty!", "Error", MessageBoxButtons.OK);
          cell.Value = true;
        }
      }

    }
  }
}
