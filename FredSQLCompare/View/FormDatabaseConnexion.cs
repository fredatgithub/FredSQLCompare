using System;
using System.Windows.Forms;

namespace FredSQLCompare.View
{
  public partial class FormDatabaseConnexion : Form
  {
    public FormDatabaseConnexion()
    {
      InitializeComponent();
    }

    private void TabPageDataSources_Click(object sender, EventArgs e)
    {

    }

    private void FormDatabaseConnexion_Load(object sender, EventArgs e)
    {
      comboBoxSourceDatabaseSource.Items.Clear();
      comboBoxSourceDatabaseSource.Items.Add("Database");

      comboBoxServerSource.Items.Clear();
      // read XML file

    }
  }
}
