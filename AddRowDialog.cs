namespace EasySetup
{
  public partial class AddRowDialog : Form
  {
    public event EventHandler WorkCompleted;
    private AddRowDialogEventArgs args = new AddRowDialogEventArgs();

    public AddRowDialog()
    {
      InitializeComponent();
    }

    private void submitBtn_Click(object sender, EventArgs e)
    {
      //Data validation
      if (NameTextBox.Text.Length == 0)
        MessageBox.Show("No name have been provided!", "Error");
      else if (LinkTextBox.Text.Length == 0)
        MessageBox.Show("No link have been provided!", "Error");
      else
      {
        args.Name = NameTextBox.Text;
        args.Link = LinkTextBox.Text;
        WorkCompleted?.Invoke(this, args);
        this.DialogResult = DialogResult.OK;
        this.Close();
      }
    }
  }
}
