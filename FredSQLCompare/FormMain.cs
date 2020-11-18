using System;
using System.Windows.Forms;
using FredSQLCompare.View;

namespace FredSQLCompare
{
  public partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();
    }

    private void FormMain_Load(object sender, EventArgs e)
    {
      FormDatabaseConnexion frmDbConnexion = new FormDatabaseConnexion();

      if (frmDbConnexion.ShowDialog() == DialogResult.OK)
      {
        //_configurationOptions = frmDbConnexion.ConfigurationOptions2;
      }

    }

    private void QuitterToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void TableLayoutPanelMain_Paint(object sender, PaintEventArgs e)
    {

    }

    private void ButtonDeploy_Click(object sender, EventArgs e)
    {

    }
  }
}
