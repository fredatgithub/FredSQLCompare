
namespace FredSQLCompare.View
{
  partial class FormDatabaseConnexion
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.tabControlDatabaseConnexion = new System.Windows.Forms.TabControl();
      this.tabPageDataSources = new System.Windows.Forms.TabPage();
      this.comboBoxServerSource = new System.Windows.Forms.ComboBox();
      this.labelSourceOperation = new System.Windows.Forms.Label();
      this.comboBoxDatabaseSource = new System.Windows.Forms.ComboBox();
      this.tabPageTableMapping = new System.Windows.Forms.TabPage();
      this.tabPageOwnerMapping = new System.Windows.Forms.TabPage();
      this.tabPageOptions = new System.Windows.Forms.TabPage();
      this.labelSourceServer = new System.Windows.Forms.Label();
      this.labelSourceAuthentication = new System.Windows.Forms.Label();
      this.comboBoxSourceAuthentication = new System.Windows.Forms.ComboBox();
      this.labelSourceUserName = new System.Windows.Forms.Label();
      this.labelSourcePassword = new System.Windows.Forms.Label();
      this.textBoxSourceName = new System.Windows.Forms.TextBox();
      this.textBoxSourcePassword = new System.Windows.Forms.TextBox();
      this.checkBoxSourceRememberCredentials = new System.Windows.Forms.CheckBox();
      this.labelSourceDatabase = new System.Windows.Forms.Label();
      this.comboBoxSourceDatabase = new System.Windows.Forms.ComboBox();
      this.buttonSourceRefresh = new System.Windows.Forms.Button();
      this.buttonSourceCreate = new System.Windows.Forms.Button();
      this.tabControlDatabaseConnexion.SuspendLayout();
      this.tabPageDataSources.SuspendLayout();
      this.SuspendLayout();
      // 
      // tabControlDatabaseConnexion
      // 
      this.tabControlDatabaseConnexion.Controls.Add(this.tabPageDataSources);
      this.tabControlDatabaseConnexion.Controls.Add(this.tabPageTableMapping);
      this.tabControlDatabaseConnexion.Controls.Add(this.tabPageOwnerMapping);
      this.tabControlDatabaseConnexion.Controls.Add(this.tabPageOptions);
      this.tabControlDatabaseConnexion.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControlDatabaseConnexion.Location = new System.Drawing.Point(0, 0);
      this.tabControlDatabaseConnexion.Name = "tabControlDatabaseConnexion";
      this.tabControlDatabaseConnexion.SelectedIndex = 0;
      this.tabControlDatabaseConnexion.Size = new System.Drawing.Size(1058, 696);
      this.tabControlDatabaseConnexion.TabIndex = 0;
      // 
      // tabPageDataSources
      // 
      this.tabPageDataSources.Controls.Add(this.buttonSourceCreate);
      this.tabPageDataSources.Controls.Add(this.buttonSourceRefresh);
      this.tabPageDataSources.Controls.Add(this.labelSourceDatabase);
      this.tabPageDataSources.Controls.Add(this.comboBoxSourceDatabase);
      this.tabPageDataSources.Controls.Add(this.checkBoxSourceRememberCredentials);
      this.tabPageDataSources.Controls.Add(this.textBoxSourcePassword);
      this.tabPageDataSources.Controls.Add(this.textBoxSourceName);
      this.tabPageDataSources.Controls.Add(this.labelSourcePassword);
      this.tabPageDataSources.Controls.Add(this.labelSourceUserName);
      this.tabPageDataSources.Controls.Add(this.comboBoxSourceAuthentication);
      this.tabPageDataSources.Controls.Add(this.labelSourceAuthentication);
      this.tabPageDataSources.Controls.Add(this.labelSourceServer);
      this.tabPageDataSources.Controls.Add(this.comboBoxServerSource);
      this.tabPageDataSources.Controls.Add(this.labelSourceOperation);
      this.tabPageDataSources.Controls.Add(this.comboBoxDatabaseSource);
      this.tabPageDataSources.Location = new System.Drawing.Point(4, 25);
      this.tabPageDataSources.Name = "tabPageDataSources";
      this.tabPageDataSources.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageDataSources.Size = new System.Drawing.Size(1050, 667);
      this.tabPageDataSources.TabIndex = 0;
      this.tabPageDataSources.Text = "Data Sources";
      this.tabPageDataSources.UseVisualStyleBackColor = true;
      this.tabPageDataSources.Click += new System.EventHandler(this.TabPageDataSources_Click);
      // 
      // comboBoxServerSource
      // 
      this.comboBoxServerSource.FormattingEnabled = true;
      this.comboBoxServerSource.Location = new System.Drawing.Point(44, 145);
      this.comboBoxServerSource.Name = "comboBoxServerSource";
      this.comboBoxServerSource.Size = new System.Drawing.Size(366, 24);
      this.comboBoxServerSource.TabIndex = 2;
      this.comboBoxServerSource.Text = "Server";
      // 
      // labelSourceOperation
      // 
      this.labelSourceOperation.AutoSize = true;
      this.labelSourceOperation.Location = new System.Drawing.Point(41, 32);
      this.labelSourceOperation.Name = "labelSourceOperation";
      this.labelSourceOperation.Size = new System.Drawing.Size(53, 17);
      this.labelSourceOperation.TabIndex = 1;
      this.labelSourceOperation.Text = "Source";
      // 
      // comboBoxDatabaseSource
      // 
      this.comboBoxDatabaseSource.FormattingEnabled = true;
      this.comboBoxDatabaseSource.Location = new System.Drawing.Point(43, 74);
      this.comboBoxDatabaseSource.Name = "comboBoxDatabaseSource";
      this.comboBoxDatabaseSource.Size = new System.Drawing.Size(293, 24);
      this.comboBoxDatabaseSource.TabIndex = 0;
      this.comboBoxDatabaseSource.Text = "Database";
      // 
      // tabPageTableMapping
      // 
      this.tabPageTableMapping.Location = new System.Drawing.Point(4, 25);
      this.tabPageTableMapping.Name = "tabPageTableMapping";
      this.tabPageTableMapping.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageTableMapping.Size = new System.Drawing.Size(1050, 667);
      this.tabPageTableMapping.TabIndex = 1;
      this.tabPageTableMapping.Text = "Table Mapping";
      this.tabPageTableMapping.UseVisualStyleBackColor = true;
      // 
      // tabPageOwnerMapping
      // 
      this.tabPageOwnerMapping.Location = new System.Drawing.Point(4, 25);
      this.tabPageOwnerMapping.Name = "tabPageOwnerMapping";
      this.tabPageOwnerMapping.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageOwnerMapping.Size = new System.Drawing.Size(1050, 667);
      this.tabPageOwnerMapping.TabIndex = 2;
      this.tabPageOwnerMapping.Text = "Owner mapping";
      this.tabPageOwnerMapping.UseVisualStyleBackColor = true;
      // 
      // tabPageOptions
      // 
      this.tabPageOptions.Location = new System.Drawing.Point(4, 25);
      this.tabPageOptions.Name = "tabPageOptions";
      this.tabPageOptions.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageOptions.Size = new System.Drawing.Size(1050, 667);
      this.tabPageOptions.TabIndex = 3;
      this.tabPageOptions.Text = "Options";
      this.tabPageOptions.UseVisualStyleBackColor = true;
      // 
      // labelSourceServer
      // 
      this.labelSourceServer.AutoSize = true;
      this.labelSourceServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelSourceServer.Location = new System.Drawing.Point(41, 112);
      this.labelSourceServer.Name = "labelSourceServer";
      this.labelSourceServer.Size = new System.Drawing.Size(56, 17);
      this.labelSourceServer.TabIndex = 3;
      this.labelSourceServer.Text = "Server";
      // 
      // labelSourceAuthentication
      // 
      this.labelSourceAuthentication.AutoSize = true;
      this.labelSourceAuthentication.Location = new System.Drawing.Point(44, 197);
      this.labelSourceAuthentication.Name = "labelSourceAuthentication";
      this.labelSourceAuthentication.Size = new System.Drawing.Size(98, 17);
      this.labelSourceAuthentication.TabIndex = 4;
      this.labelSourceAuthentication.Text = "Authentication";
      // 
      // comboBoxSourceAuthentication
      // 
      this.comboBoxSourceAuthentication.FormattingEnabled = true;
      this.comboBoxSourceAuthentication.Location = new System.Drawing.Point(148, 197);
      this.comboBoxSourceAuthentication.Name = "comboBoxSourceAuthentication";
      this.comboBoxSourceAuthentication.Size = new System.Drawing.Size(293, 24);
      this.comboBoxSourceAuthentication.TabIndex = 5;
      this.comboBoxSourceAuthentication.Text = "Authentication";
      // 
      // labelSourceUserName
      // 
      this.labelSourceUserName.AutoSize = true;
      this.labelSourceUserName.Location = new System.Drawing.Point(44, 227);
      this.labelSourceUserName.Name = "labelSourceUserName";
      this.labelSourceUserName.Size = new System.Drawing.Size(79, 17);
      this.labelSourceUserName.TabIndex = 6;
      this.labelSourceUserName.Text = "User Name";
      // 
      // labelSourcePassword
      // 
      this.labelSourcePassword.AutoSize = true;
      this.labelSourcePassword.Location = new System.Drawing.Point(44, 257);
      this.labelSourcePassword.Name = "labelSourcePassword";
      this.labelSourcePassword.Size = new System.Drawing.Size(69, 17);
      this.labelSourcePassword.TabIndex = 8;
      this.labelSourcePassword.Text = "Password";
      // 
      // textBoxSourceName
      // 
      this.textBoxSourceName.Location = new System.Drawing.Point(148, 227);
      this.textBoxSourceName.Name = "textBoxSourceName";
      this.textBoxSourceName.Size = new System.Drawing.Size(293, 22);
      this.textBoxSourceName.TabIndex = 9;
      // 
      // textBoxSourcePassword
      // 
      this.textBoxSourcePassword.Location = new System.Drawing.Point(148, 257);
      this.textBoxSourcePassword.Name = "textBoxSourcePassword";
      this.textBoxSourcePassword.Size = new System.Drawing.Size(293, 22);
      this.textBoxSourcePassword.TabIndex = 10;
      // 
      // checkBoxSourceRememberCredentials
      // 
      this.checkBoxSourceRememberCredentials.AutoSize = true;
      this.checkBoxSourceRememberCredentials.Location = new System.Drawing.Point(148, 297);
      this.checkBoxSourceRememberCredentials.Name = "checkBoxSourceRememberCredentials";
      this.checkBoxSourceRememberCredentials.Size = new System.Drawing.Size(172, 21);
      this.checkBoxSourceRememberCredentials.TabIndex = 11;
      this.checkBoxSourceRememberCredentials.Text = "Remember credentials";
      this.checkBoxSourceRememberCredentials.UseVisualStyleBackColor = true;
      // 
      // labelSourceDatabase
      // 
      this.labelSourceDatabase.AutoSize = true;
      this.labelSourceDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelSourceDatabase.Location = new System.Drawing.Point(44, 336);
      this.labelSourceDatabase.Name = "labelSourceDatabase";
      this.labelSourceDatabase.Size = new System.Drawing.Size(77, 17);
      this.labelSourceDatabase.TabIndex = 13;
      this.labelSourceDatabase.Text = "Database";
      // 
      // comboBoxSourceDatabase
      // 
      this.comboBoxSourceDatabase.FormattingEnabled = true;
      this.comboBoxSourceDatabase.Location = new System.Drawing.Point(47, 369);
      this.comboBoxSourceDatabase.Name = "comboBoxSourceDatabase";
      this.comboBoxSourceDatabase.Size = new System.Drawing.Size(366, 24);
      this.comboBoxSourceDatabase.TabIndex = 12;
      this.comboBoxSourceDatabase.Text = "Database name";
      // 
      // buttonSourceRefresh
      // 
      this.buttonSourceRefresh.Location = new System.Drawing.Point(440, 370);
      this.buttonSourceRefresh.Name = "buttonSourceRefresh";
      this.buttonSourceRefresh.Size = new System.Drawing.Size(75, 23);
      this.buttonSourceRefresh.TabIndex = 14;
      this.buttonSourceRefresh.Text = "Refresh";
      this.buttonSourceRefresh.UseVisualStyleBackColor = true;
      // 
      // buttonSourceCreate
      // 
      this.buttonSourceCreate.Location = new System.Drawing.Point(47, 409);
      this.buttonSourceCreate.Name = "buttonSourceCreate";
      this.buttonSourceCreate.Size = new System.Drawing.Size(75, 23);
      this.buttonSourceCreate.TabIndex = 15;
      this.buttonSourceCreate.Text = "Create";
      this.buttonSourceCreate.UseVisualStyleBackColor = true;
      // 
      // FormDatabaseConnexion
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1058, 696);
      this.Controls.Add(this.tabControlDatabaseConnexion);
      this.Name = "FormDatabaseConnexion";
      this.Text = "FormDatabaseConnexion";
      this.Load += new System.EventHandler(this.FormDatabaseConnexion_Load);
      this.tabControlDatabaseConnexion.ResumeLayout(false);
      this.tabPageDataSources.ResumeLayout(false);
      this.tabPageDataSources.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tabControlDatabaseConnexion;
    private System.Windows.Forms.TabPage tabPageDataSources;
    private System.Windows.Forms.TabPage tabPageTableMapping;
    private System.Windows.Forms.TabPage tabPageOwnerMapping;
    private System.Windows.Forms.TabPage tabPageOptions;
    private System.Windows.Forms.ComboBox comboBoxServerSource;
    private System.Windows.Forms.Label labelSourceOperation;
    private System.Windows.Forms.ComboBox comboBoxDatabaseSource;
    private System.Windows.Forms.Label labelSourceDatabase;
    private System.Windows.Forms.ComboBox comboBoxSourceDatabase;
    private System.Windows.Forms.CheckBox checkBoxSourceRememberCredentials;
    private System.Windows.Forms.TextBox textBoxSourcePassword;
    private System.Windows.Forms.TextBox textBoxSourceName;
    private System.Windows.Forms.Label labelSourcePassword;
    private System.Windows.Forms.Label labelSourceUserName;
    private System.Windows.Forms.ComboBox comboBoxSourceAuthentication;
    private System.Windows.Forms.Label labelSourceAuthentication;
    private System.Windows.Forms.Label labelSourceServer;
    private System.Windows.Forms.Button buttonSourceCreate;
    private System.Windows.Forms.Button buttonSourceRefresh;
  }
}