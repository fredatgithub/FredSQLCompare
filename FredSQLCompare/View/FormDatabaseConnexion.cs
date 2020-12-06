﻿using FredSQLCompare.DAL;
using FredSQLCompare.Model;
using System;
using System.Collections.Generic;
using System.Net;
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
      comboBoxTargetSource.Items.Clear();
      comboBoxTargetSource.Items.Add($"{Dns.GetHostName()}");

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
      comboBoxTargetSource.SelectedIndex = Properties.Settings.Default.comboBoxTargetSource;

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
      string sqlQuery = Connexions.GetAllDatabaseNamesRequest();
      //string sqlQuery = "select name from sys.databases";
      string hostName = Dns.GetHostName();
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
      // refresh the list of source database combobox
      // get all databases for the db connexion parameters entered

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
      if (comboBoxTargetSource.SelectedIndex != -1)
      {
        Properties.Settings.Default.comboBoxTargetSource = comboBoxTargetSource.SelectedIndex;
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
  }
}
