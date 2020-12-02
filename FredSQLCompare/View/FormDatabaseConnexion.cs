using System;
using System.Windows.Forms;
using static FredSQLCompare.Utile.Enumerations;

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

      comboBoxSourceAuthentication.SelectedIndex = Properties.Settings.Default.ComboBoxSourceAuthenticationIndex;
      comboBoxTargetAuthentication.SelectedIndex = Properties.Settings.Default.ComboBoxTargetAuthenticationIndex;
      checkBoxSourceRememberCredentials.Checked = Properties.Settings.Default.CheckBoxSourceRememberCredentials;
      checkBoxTargetRememberCredentials.Checked = Properties.Settings.Default.CheckBoxTargetRememberCredentials;
      textBoxTargetName.Text = Properties.Settings.Default.textBoxTargetName;
      textBoxSourceName.Text = Properties.Settings.Default.textBoxSourceName;
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
      // recording controls states
      Properties.Settings.Default.CheckBoxSourceRememberCredentials = checkBoxSourceRememberCredentials.Checked;
      Properties.Settings.Default.CheckBoxTargetRememberCredentials = checkBoxTargetRememberCredentials.Checked;

      Properties.Settings.Default.Save();

      if (comboBoxSourceAuthentication.SelectedIndex != -1 && comboBoxSourceAuthentication.SelectedItem.ToString().ToLower().Replace(" ", "") == AuthenticationTypes.AuthenticationSQLServer.ToString().ToLower() && string.IsNullOrEmpty(textBoxSourcePassword.Text))
      {
        MessageBox.Show("The password cannot be empty if SQL authentication is choosen");
        return;
      }

      if (comboBoxSourceAuthentication.SelectedIndex != -1 && comboBoxSourceAuthentication.SelectedItem.ToString().ToLower().Replace(" ", "") == AuthenticationTypes.AuthenticationSQLServer.ToString().ToLower() && string.IsNullOrEmpty(textBoxSourceName.Text))
      {
        MessageBox.Show("The user name cannot be empty if SQL authentication is choosen");
        return;
      }


      //saving controls state
      Properties.Settings.Default.ComboBoxSourceAuthenticationIndex = comboBoxSourceAuthentication.SelectedIndex;
      Properties.Settings.Default.ComboBoxTargetAuthenticationIndex = comboBoxTargetAuthentication.SelectedIndex;
      Properties.Settings.Default.CheckBoxSourceRememberCredentials = checkBoxSourceRememberCredentials.Checked;
      Properties.Settings.Default.CheckBoxTargetRememberCredentials = checkBoxTargetRememberCredentials.Checked;
      Properties.Settings.Default.Save();
      Properties.Settings.Default.textBoxTargetName = textBoxTargetName.Text;
      Properties.Settings.Default.textBoxSourceName = textBoxSourceName.Text;
      Close();
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
