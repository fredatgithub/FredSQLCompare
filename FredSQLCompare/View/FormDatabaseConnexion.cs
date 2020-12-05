using FredSQLCompare.DAL;
using FredSQLCompare.Model;
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
      comboBoxServerSource.Items.Add("DESKTOP-MSI");
      // should read XML file TODO

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
      // create a new database

    }

    private void ButtonTargetCreate_Click(object sender, EventArgs e)
    {
      // create a new database

    }

    private void ButtonSourceRefresh_Click(object sender, EventArgs e)
    {
      // refresh the list of source database combobox
      // use of GetAllDatabaseNamesRequest() method
      string request = Connexions.GetAllDatabaseNamesRequest();
      DatabaseAuthentication dbConnexion = new DatabaseAuthentication
      {
        UserName = textBoxSourceName.Text,
        UserPassword = textBoxSourcePassword.Text,
        ServerName = comboBoxServerSource.SelectedItem.ToString(),
        DatabaseName = "master"
      };

      RecordParameters();
      //string sqlQuery = Connexions.GetAllDatabaseNamesRequest();
      string sqlQuery = "select name from sys.databases";

      var queryResult = DALHelper.ExecuteSqlQuery(sqlQuery, dbConnexion.DatabaseName, "DESKTOP-MSI");
      MessageBox.Show(queryResult);
    }

    private void ButtonTargetRefresh_Click(object sender, EventArgs e)
    {
      // refresh the list of source database combobox
      // get all databases for the db connexion parameters entered

    }

    private void ButtonCompareSave_Click(object sender, EventArgs e)
    {
      // saving parameters

    }

    private void ButtonCompareSaveAs_Click(object sender, EventArgs e)
    {
      // saving parameters as ...

    }

    private void ButtonCompareToRightArrow_Click(object sender, EventArgs e)
    {
      // left parameters go to right
      textBoxTargetName.Text = textBoxSourceName.Text;
      textBoxTargetPassword.Text = textBoxSourcePassword.Text;
      comboBoxTargetAuthentication.SelectedIndex = comboBoxSourceAuthentication.SelectedIndex;
      checkBoxTargetRememberCredentials.Checked = checkBoxSourceRememberCredentials.Checked;
    }

    private void ButtonCompareToRightAndLeftArrow_Click(object sender, EventArgs e)
    {
      // switching parameters right to left
      string tmpTextTargetNameText = textBoxTargetName.Text;
      string tmpTextBoxTargetPasswordText = textBoxTargetPassword.Text;
      int tmpComboBoxTargetAuthenticationSelectedIndex = comboBoxTargetAuthentication.SelectedIndex;
      bool checkBoxTargetRememberCredentialsChecked = checkBoxTargetRememberCredentials.Checked;

      ButtonCompareToRightArrow_Click(sender, e);

      textBoxSourceName.Text = tmpTextTargetNameText;
      textBoxSourcePassword.Text = tmpTextBoxTargetPasswordText;
      comboBoxSourceAuthentication.SelectedIndex = tmpComboBoxTargetAuthenticationSelectedIndex;
      checkBoxSourceRememberCredentials.Checked = checkBoxTargetRememberCredentialsChecked;
    }

    private void ButtonCompareToLeftArrow_Click(object sender, EventArgs e)
    {
      // right parameters go to left
      textBoxSourceName.Text = textBoxTargetName.Text;
      textBoxSourcePassword.Text = textBoxTargetPassword.Text;
      comboBoxSourceAuthentication.SelectedIndex = comboBoxTargetAuthentication.SelectedIndex;
      checkBoxSourceRememberCredentials.Checked = checkBoxTargetRememberCredentials.Checked;
    }

    private void ButtonCompareCompareNowCancel_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void ButtonCompareCompareNow_Click(object sender, EventArgs e)
    {
      RecordParameters();

    }

    private void RecordParameters()
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

      Properties.Settings.Default.textBoxTargetName = textBoxTargetName.Text;
      Properties.Settings.Default.textBoxSourceName = textBoxSourceName.Text;

      Properties.Settings.Default.Save();
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
