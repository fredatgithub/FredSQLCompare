using FredSQLCompare.DAL;
using FredSQLCompare.Model;
using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;
using static FredSQLCompare.Utilities.Enumerations;

namespace FredSQLCompare.View
{
  public partial class FormDatabaseConnexion : Form
  {
    public FormDatabaseConnexion()
    {
      InitializeComponent();
    }

    private void FormDatabaseConnexion_Load(object sender, EventArgs e)
    {
      comboBoxSourceDatabaseSource.Items.Clear();
      comboBoxSourceDatabaseSource.Items.Add("Database");
      comboBoxSourceDatabaseSource.Items.Add("Backup");
      comboBoxSourceDatabaseSource.Items.Add("Snapshot");
      comboBoxSourceDatabaseSource.Items.Add("Scripts folder");
      comboBoxSourceDatabaseSource.Items.Add("SQL Source Control");
      comboBoxSourceDatabaseSource.Items.Add("SQL Change Automation");
      comboBoxSourceDatabaseSource.SelectedIndex = Properties.Settings.Default.comboBoxSourceDatabaseSource;

      comboBoxTargetDatabaseTarget.Items.Clear();
      comboBoxTargetDatabaseTarget.Items.Add("Database");
      comboBoxTargetDatabaseTarget.Items.Add("Backup");
      comboBoxTargetDatabaseTarget.Items.Add("Snapshot");
      comboBoxTargetDatabaseTarget.Items.Add("Scripts folder");
      comboBoxTargetDatabaseTarget.Items.Add("SQL Source Control");
      comboBoxTargetDatabaseTarget.Items.Add("SQL Change Automation");
      comboBoxTargetDatabaseTarget.SelectedIndex = Properties.Settings.Default.comboBoxTargetDatabaseTarget;

      // should read XML file TODO
      comboBoxServerSource.Items.Clear();
      comboBoxServerSource.Items.Add($"{Dns.GetHostName()}");
      comboBoxServerTarget.Items.Clear();
      comboBoxServerTarget.Items.Add($"{Dns.GetHostName()}");

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
      comboBoxServerSource.SelectedIndex = Properties.Settings.Default.comboBoxServerSource;
      comboBoxServerTarget.SelectedIndex = Properties.Settings.Default.comboBoxTargetSource;

      comboBoxSourceDatabase.Items.Clear();
      foreach (string item in Properties.Settings.Default.comboBoxSourceDatabase.Split(';'))
      {
        comboBoxSourceDatabase.Items.Add(item);
      }

      comboBoxTargetDatabase.Items.Clear();
      foreach (string item in Properties.Settings.Default.comboBoxTargetDatabase.Split(';'))
      {
        comboBoxTargetDatabase.Items.Add(item);
      }
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
      DatabaseAuthentication dbConnexion = new DatabaseAuthentication
      {
        UserName = textBoxSourceName.Text,
        UserPassword = textBoxSourcePassword.Text,
        ServerName = comboBoxServerSource.SelectedItem.ToString(),
        DatabaseName = "master"
      };

      RecordParameters();
      string sqlQuery = ConnectionSqlServer.GetAllDatabaseNamesRequest();
      //string sqlQuery = "select name from sys.databases";
      if (!DALHelper.VerifyDatabaseConnexion(sqlQuery, dbConnexion.DatabaseName, dbConnexion.ServerName))
      {
        MessageBox.Show($"Cannot connect to the database: {dbConnexion.DatabaseName} on the server: {dbConnexion.ServerName}");
        return;
      }

      List<string> listOfDatabaseName = DALHelper.ExecuteSqlQueryToListOfStrings(sqlQuery, "master", Dns.GetHostName());

      comboBoxSourceDatabase.Items.Clear();
      foreach (string name in listOfDatabaseName)
      {
        comboBoxSourceDatabase.Items.Add(name);
      }
    }

    private void ButtonTargetRefresh_Click(object sender, EventArgs e)
    {
      // refresh the list of target database combobox
      DatabaseAuthentication dbConnexion = new DatabaseAuthentication
      {
        UserName = textBoxTargetName.Text,
        UserPassword = textBoxTargetPassword.Text,
        ServerName = comboBoxServerTarget.SelectedItem.ToString(),
        DatabaseName = "master"
      };

      RecordParameters();
      string sqlQuery = ConnectionSqlServer.GetAllDatabaseNamesRequest();
      if (!DALHelper.VerifyDatabaseConnexion(sqlQuery, dbConnexion.DatabaseName, dbConnexion.ServerName))
      {
        MessageBox.Show($"Cannot connect to the database: {dbConnexion.DatabaseName} on the server: {dbConnexion.ServerName}");
        return;
      }

      List<string> listOfDatabaseName = DALHelper.ExecuteSqlQueryToListOfStrings(sqlQuery, "master", Dns.GetHostName());

      comboBoxTargetDatabase.Items.Clear();
      foreach (string name in listOfDatabaseName)
      {
        comboBoxTargetDatabase.Items.Add(name);
      }
    }

    private void ButtonCompareSave_Click(object sender, EventArgs e)
    {
      // saving parameters
      // if scp file doesn't exist, then create a new file.

    }

    private void ButtonCompareSaveAs_Click(object sender, EventArgs e)
    {
      // saving parameters as ... SCP XML file

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
      if (comboBoxServerSource.SelectedIndex == -1)
      {
        MessageBox.Show("You have to choose a source SQL server");
        comboBoxServerSource.Focus();
        return;
      }

      if (comboBoxServerTarget.SelectedIndex == -1)
      {
        MessageBox.Show("You have to choose a target SQL server");
        comboBoxServerTarget.Focus();
        return;
      }

      //comboBoxSourceDatabase
      if (comboBoxSourceDatabase.SelectedIndex == -1)
      {
        MessageBox.Show("You have to choose a source database");
        comboBoxSourceDatabase.Focus();
        return;
      }

      //comboBoxTargetDatabase
      if (comboBoxTargetDatabase.SelectedIndex == -1)
      {
        MessageBox.Show("You have to choose a target database");
        comboBoxTargetDatabase.Focus();
        return;
      }

      // verify source db connexion
      DatabaseAuthentication dbConnexionSource = new DatabaseAuthentication
      {
        UserName = textBoxSourceName.Text,
        UserPassword = textBoxSourcePassword.Text,
        ServerName = comboBoxServerSource.SelectedItem.ToString(),
        DatabaseName = comboBoxSourceDatabase.SelectedItem.ToString()
      };

      string sqlQuery = ConnectionSqlServer.GetAllTableNamesRequest();

      // verify target db connexion
      if (!DALHelper.VerifyDatabaseConnexion(sqlQuery, dbConnexionSource.DatabaseName, dbConnexionSource.ServerName))
      {
        MessageBox.Show($"Cannot connect to the database: {dbConnexionSource.DatabaseName} on the server: {dbConnexionSource.ServerName}");
        return;
      }

      List<string> listOfTableNameSource = DALHelper.ExecuteSqlQueryToListOfStrings(sqlQuery, dbConnexionSource.DatabaseName, Dns.GetHostName());
      if (!Utilities.Utility.WriteTextFile(Properties.Settings.Default.listOfTableNameSource, listOfTableNameSource))
      {
        MessageBox.Show($"Something went wrong when trying to write all source table names to the file: {Properties.Settings.Default.listOfTableNameSource}");
      }

      DatabaseAuthentication dbConnexionTarget = new DatabaseAuthentication
      {
        UserName = textBoxTargetName.Text,
        UserPassword = textBoxTargetPassword.Text,
        ServerName = comboBoxServerTarget.SelectedItem.ToString(),
        DatabaseName = comboBoxTargetDatabase.SelectedItem.ToString()
      };

      sqlQuery = ConnectionSqlServer.GetAllTableNamesRequest();
      // verify db connexion
      if (!DALHelper.VerifyDatabaseConnexion(sqlQuery, dbConnexionTarget.DatabaseName, dbConnexionTarget.ServerName))
      {
        MessageBox.Show($"Cannot connect to the database: {dbConnexionTarget.DatabaseName} on the server: {dbConnexionTarget.ServerName}");
        return;
      }

      // write to file target table names. 
      List<string> listOfTableNameTarget = DALHelper.ExecuteSqlQueryToListOfStrings(sqlQuery, dbConnexionTarget.DatabaseName, Dns.GetHostName());
      if (!Utilities.Utility.WriteTextFile(Properties.Settings.Default.listOfTableNameTarget, listOfTableNameTarget))
      {
        MessageBox.Show($"Something went wrong when trying to write all target table names to the file: {Properties.Settings.Default.listOfTableNameSource}");
      }

      // get GetAllStoredProcedureRequest
      sqlQuery = ConnectionSqlServer.GetAllStoredProcedureRequest();
      // verify db connexion
      if (!DALHelper.VerifyDatabaseConnexion(sqlQuery, dbConnexionTarget.DatabaseName, dbConnexionTarget.ServerName))
      {
        MessageBox.Show($"Cannot connect to the database: {dbConnexionTarget.DatabaseName} on the server: {dbConnexionTarget.ServerName}");
        return;
      }

      // write to file target table names. 
      List<string> listOfSPTarget = DALHelper.ExecuteSqlQueryToListOfStrings(sqlQuery, dbConnexionTarget.DatabaseName, Dns.GetHostName());
      if (!Utilities.Utility.WriteTextFile(Properties.Settings.Default.listOfStoredProcedureNameTarget, listOfSPTarget))
      {
        MessageBox.Show($"Something went wrong when trying to write all Target Stored procedures names to the file: {Properties.Settings.Default.listOfStoredProcedureNameTarget}");
      }

      // get GetAllStoredProcedureRequest
      sqlQuery = ConnectionSqlServer.GetAllStoredProcedureRequest();
      // verify db connexion
      if (!DALHelper.VerifyDatabaseConnexion(sqlQuery, dbConnexionSource.DatabaseName, dbConnexionSource.ServerName))
      {
        MessageBox.Show($"Cannot connect to the database: {dbConnexionSource.DatabaseName} on the server: {dbConnexionSource.ServerName}");
        return;
      }

      // write to file source SP names. 
      List<string> listOfSPSource = DALHelper.ExecuteSqlQueryToListOfStrings(sqlQuery, dbConnexionSource.DatabaseName, Dns.GetHostName());
      if (!Utilities.Utility.WriteTextFile(Properties.Settings.Default.listOfStoredProcedureNameSource, listOfSPSource))
      {
        MessageBox.Show($"Something went wrong when trying to write all Source Stored procedures names to the file: {Properties.Settings.Default.listOfStoredProcedureNameSource}");
      }

      // Get All GetAllFunctionsRequest 
      sqlQuery = ConnectionSqlServer.GetAllFunctionsRequest();
      // verify db connexion
      if (!DALHelper.VerifyDatabaseConnexion(sqlQuery, dbConnexionTarget.DatabaseName, dbConnexionTarget.ServerName))
      {
        MessageBox.Show($"Cannot connect to the database: {dbConnexionTarget.DatabaseName} on the server: {dbConnexionTarget.ServerName}");
        return;
      }

      // write to file target table names. 
      List<string> listOfFunctionsTarget = DALHelper.ExecuteSqlQueryToListOfStrings(sqlQuery, dbConnexionTarget.DatabaseName, Dns.GetHostName());
      if (!Utilities.Utility.WriteTextFile(Properties.Settings.Default.listOfFunctionNameTarget, listOfFunctionsTarget))
      {
        MessageBox.Show($"Something went wrong when trying to write all Target Stored procedures names to the file: {Properties.Settings.Default.listOfStoredProcedureNameTarget}");
      }

      // get GetAllFunctionsRequest
      sqlQuery = ConnectionSqlServer.GetAllFunctionsRequest();
      // verify db connexion
      if (!DALHelper.VerifyDatabaseConnexion(sqlQuery, dbConnexionSource.DatabaseName, dbConnexionSource.ServerName))
      {
        MessageBox.Show($"Cannot connect to the database: {dbConnexionSource.DatabaseName} on the server: {dbConnexionSource.ServerName}");
        return;
      }

      // write to file source function names. 
      List<string> listOfFunctionsSource = DALHelper.ExecuteSqlQueryToListOfStrings(sqlQuery, dbConnexionSource.DatabaseName, Dns.GetHostName());
      if (!Utilities.Utility.WriteTextFile(Properties.Settings.Default.listOfFunctionNameSource, listOfFunctionsSource))
      {
        MessageBox.Show($"Something went wrong when trying to write all Source Stored procedures names to the file: {Properties.Settings.Default.listOfStoredProcedureNameSource}");
      }

      // close the win form
      Close();
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

      // comboBoxServerSource
      if (comboBoxServerSource.SelectedIndex != -1)
      {
        Properties.Settings.Default.comboBoxServerSource = comboBoxServerSource.SelectedIndex;
      }

      // comboBoxTargetSource
      if (comboBoxServerTarget.SelectedIndex != -1)
      {
        Properties.Settings.Default.comboBoxTargetSource = comboBoxServerTarget.SelectedIndex;
      }

      //saving controls state
      Properties.Settings.Default.ComboBoxSourceAuthenticationIndex = comboBoxSourceAuthentication.SelectedIndex;
      Properties.Settings.Default.ComboBoxTargetAuthenticationIndex = comboBoxTargetAuthentication.SelectedIndex;
      Properties.Settings.Default.CheckBoxSourceRememberCredentials = checkBoxSourceRememberCredentials.Checked;
      Properties.Settings.Default.CheckBoxTargetRememberCredentials = checkBoxTargetRememberCredentials.Checked;

      Properties.Settings.Default.textBoxTargetName = textBoxTargetName.Text;
      Properties.Settings.Default.textBoxSourceName = textBoxSourceName.Text;

      Properties.Settings.Default.comboBoxSourceDatabaseSource = comboBoxSourceDatabaseSource.SelectedIndex;
      Properties.Settings.Default.comboBoxTargetDatabaseTarget = comboBoxTargetDatabaseTarget.SelectedIndex;

      //comboBoxTargetDatabase
      string oneString = string.Empty;
      if (comboBoxTargetDatabase.Items.Count > 0)
      {
        foreach (var item in comboBoxTargetDatabase.Items)
        {
          oneString += $"{item};";
        }

        oneString = oneString.TrimEnd(';');
      }

      Properties.Settings.Default.comboBoxTargetDatabase = oneString;

      //comboBoxTargetDatabase
      oneString = string.Empty;
      if (comboBoxSourceDatabase.Items.Count > 0)
      {
        foreach (var item in comboBoxSourceDatabase.Items)
        {
          oneString += $"{item};";
        }

        oneString = oneString.TrimEnd(';');
      }

      Properties.Settings.Default.comboBoxSourceDatabase = oneString;
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

    private void ButtonCopyPasswordSourceToTarget_Click(object sender, EventArgs e)
    {
      textBoxTargetPassword.Text = textBoxSourcePassword.Text;
    }
  }
}
