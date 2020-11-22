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

      comboBoxSourceAuthentication.Items.Clear();
      comboBoxSourceAuthentication.Items.Add("Authentication Windows");
      comboBoxSourceAuthentication.Items.Add("Authentication SQL Server");
      comboBoxSourceAuthentication.Items.Add("Azure Active Directory - MFA universal Authentication");
      comboBoxSourceAuthentication.Items.Add("Azure Active Directory - Password");
      comboBoxSourceAuthentication.Items.Add("Azure Active Directory - Integrated");

      comboBoxTargetAuthentication.Items.Clear();
      comboBoxTargetAuthentication.Items.Add("Authentication Windows");
      comboBoxTargetAuthentication.Items.Add("Authentication SQL Server");
      comboBoxTargetAuthentication.Items.Add("Azure Active Directory - MFA universal Authentication");
      comboBoxTargetAuthentication.Items.Add("Azure Active Directory - Password");
      comboBoxTargetAuthentication.Items.Add("Azure Active Directory - Integrated");


    }

    private void ButtonSourceCreate_Click(object sender, EventArgs e)
    {

    }

    private void ButtonTargetCreate_Click(object sender, EventArgs e)
    {

    }

    private void ButtonSourceRefresh_Click(object sender, EventArgs e)
    {

    }

    private void ButtonTargetRefresh_Click(object sender, EventArgs e)
    {

    }

    private void ButtonCompareSave_Click(object sender, EventArgs e)
    {

    }

    private void ButtonCompareSaveAs_Click(object sender, EventArgs e)
    {

    }

    private void ButtonCompareToRightArrow_Click(object sender, EventArgs e)
    {

    }

    private void ButtonCompareToRightAndLeftArrow_Click(object sender, EventArgs e)
    {

    }

    private void ButtonCompareToLeftArrow_Click(object sender, EventArgs e)
    {

    }

    private void ButtonCompareCompareNowCancel_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void ButtonCompareCompareNow_Click(object sender, EventArgs e)
    {

    }

    private void ComboBoxSourceDatabase_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(textBoxSourceName.Text))
      {
        MessageBox.Show("User name cannot be emptied");
        return;
      }

      if (string.IsNullOrEmpty(textBoxSourcePassword.Text))
      {
        MessageBox.Show("Password cannot be emptied");
        return;
      }

    }

    private void ComboBoxTargetDatabase_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(textBoxTargetName.Text))
      {
        MessageBox.Show("User name cannot be emptied");
        return;
      }

      if (string.IsNullOrEmpty(textBoxTargetPassword.Text))
      {
        MessageBox.Show("Password cannot be emptied");
        return;
      }
    }
  }
}
