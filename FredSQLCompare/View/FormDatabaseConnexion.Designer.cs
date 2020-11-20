
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
      this.comboBoxSourceDatabaseSource = new System.Windows.Forms.ComboBox();
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
      this.buttonTargetCreate = new System.Windows.Forms.Button();
      this.buttonTargetRefresh = new System.Windows.Forms.Button();
      this.labelTargetDatabase = new System.Windows.Forms.Label();
      this.comboBoxTargetDatabase = new System.Windows.Forms.ComboBox();
      this.checkBoxTargetRememberCredentials = new System.Windows.Forms.CheckBox();
      this.textBoxTargetPassword = new System.Windows.Forms.TextBox();
      this.textBoxTargetName = new System.Windows.Forms.TextBox();
      this.labelTargetPassword = new System.Windows.Forms.Label();
      this.labelTargetUserName = new System.Windows.Forms.Label();
      this.comboBoxTargetAuthentication = new System.Windows.Forms.ComboBox();
      this.labelTargetAuthentication = new System.Windows.Forms.Label();
      this.labelTargetServer = new System.Windows.Forms.Label();
      this.comboBoxTargetSource = new System.Windows.Forms.ComboBox();
      this.labelTargetOperation = new System.Windows.Forms.Label();
      this.comboBoxTargetDatabaseTarget = new System.Windows.Forms.ComboBox();
      this.buttonCompareSave = new System.Windows.Forms.Button();
      this.buttonCompareSaveAs = new System.Windows.Forms.Button();
      this.buttonCompareToRightArrow = new System.Windows.Forms.Button();
      this.buttonCompareToRightAndLeftArrow = new System.Windows.Forms.Button();
      this.buttonCompareToLeftArrow = new System.Windows.Forms.Button();
      this.buttonCompareCompareNow = new System.Windows.Forms.Button();
      this.buttonCompareCompareNowCancel = new System.Windows.Forms.Button();
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
      this.tabControlDatabaseConnexion.Size = new System.Drawing.Size(1058, 600);
      this.tabControlDatabaseConnexion.TabIndex = 0;
      // 
      // tabPageDataSources
      // 
      this.tabPageDataSources.Controls.Add(this.buttonCompareCompareNowCancel);
      this.tabPageDataSources.Controls.Add(this.buttonCompareCompareNow);
      this.tabPageDataSources.Controls.Add(this.buttonCompareToLeftArrow);
      this.tabPageDataSources.Controls.Add(this.buttonCompareToRightAndLeftArrow);
      this.tabPageDataSources.Controls.Add(this.buttonCompareToRightArrow);
      this.tabPageDataSources.Controls.Add(this.buttonCompareSaveAs);
      this.tabPageDataSources.Controls.Add(this.buttonCompareSave);
      this.tabPageDataSources.Controls.Add(this.buttonTargetCreate);
      this.tabPageDataSources.Controls.Add(this.buttonTargetRefresh);
      this.tabPageDataSources.Controls.Add(this.labelTargetDatabase);
      this.tabPageDataSources.Controls.Add(this.comboBoxTargetDatabase);
      this.tabPageDataSources.Controls.Add(this.checkBoxTargetRememberCredentials);
      this.tabPageDataSources.Controls.Add(this.textBoxTargetPassword);
      this.tabPageDataSources.Controls.Add(this.textBoxTargetName);
      this.tabPageDataSources.Controls.Add(this.labelTargetPassword);
      this.tabPageDataSources.Controls.Add(this.labelTargetUserName);
      this.tabPageDataSources.Controls.Add(this.comboBoxTargetAuthentication);
      this.tabPageDataSources.Controls.Add(this.labelTargetAuthentication);
      this.tabPageDataSources.Controls.Add(this.labelTargetServer);
      this.tabPageDataSources.Controls.Add(this.comboBoxTargetSource);
      this.tabPageDataSources.Controls.Add(this.labelTargetOperation);
      this.tabPageDataSources.Controls.Add(this.comboBoxTargetDatabaseTarget);
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
      this.tabPageDataSources.Controls.Add(this.comboBoxSourceDatabaseSource);
      this.tabPageDataSources.Location = new System.Drawing.Point(4, 25);
      this.tabPageDataSources.Name = "tabPageDataSources";
      this.tabPageDataSources.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageDataSources.Size = new System.Drawing.Size(1050, 571);
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
      // comboBoxSourceDatabaseSource
      // 
      this.comboBoxSourceDatabaseSource.FormattingEnabled = true;
      this.comboBoxSourceDatabaseSource.Location = new System.Drawing.Point(43, 74);
      this.comboBoxSourceDatabaseSource.Name = "comboBoxSourceDatabaseSource";
      this.comboBoxSourceDatabaseSource.Size = new System.Drawing.Size(293, 24);
      this.comboBoxSourceDatabaseSource.TabIndex = 0;
      this.comboBoxSourceDatabaseSource.Text = "Database";
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
      this.buttonSourceRefresh.Location = new System.Drawing.Point(424, 370);
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
      // buttonTargetCreate
      // 
      this.buttonTargetCreate.Location = new System.Drawing.Point(536, 409);
      this.buttonTargetCreate.Name = "buttonTargetCreate";
      this.buttonTargetCreate.Size = new System.Drawing.Size(75, 23);
      this.buttonTargetCreate.TabIndex = 30;
      this.buttonTargetCreate.Text = "Create";
      this.buttonTargetCreate.UseVisualStyleBackColor = true;
      // 
      // buttonTargetRefresh
      // 
      this.buttonTargetRefresh.Location = new System.Drawing.Point(913, 370);
      this.buttonTargetRefresh.Name = "buttonTargetRefresh";
      this.buttonTargetRefresh.Size = new System.Drawing.Size(75, 23);
      this.buttonTargetRefresh.TabIndex = 29;
      this.buttonTargetRefresh.Text = "Refresh";
      this.buttonTargetRefresh.UseVisualStyleBackColor = true;
      // 
      // labelTargetDatabase
      // 
      this.labelTargetDatabase.AutoSize = true;
      this.labelTargetDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelTargetDatabase.Location = new System.Drawing.Point(533, 336);
      this.labelTargetDatabase.Name = "labelTargetDatabase";
      this.labelTargetDatabase.Size = new System.Drawing.Size(77, 17);
      this.labelTargetDatabase.TabIndex = 28;
      this.labelTargetDatabase.Text = "Database";
      // 
      // comboBoxTargetDatabase
      // 
      this.comboBoxTargetDatabase.FormattingEnabled = true;
      this.comboBoxTargetDatabase.Location = new System.Drawing.Point(536, 369);
      this.comboBoxTargetDatabase.Name = "comboBoxTargetDatabase";
      this.comboBoxTargetDatabase.Size = new System.Drawing.Size(366, 24);
      this.comboBoxTargetDatabase.TabIndex = 27;
      this.comboBoxTargetDatabase.Text = "Database name";
      // 
      // checkBoxTargetRememberCredentials
      // 
      this.checkBoxTargetRememberCredentials.AutoSize = true;
      this.checkBoxTargetRememberCredentials.Location = new System.Drawing.Point(637, 297);
      this.checkBoxTargetRememberCredentials.Name = "checkBoxTargetRememberCredentials";
      this.checkBoxTargetRememberCredentials.Size = new System.Drawing.Size(172, 21);
      this.checkBoxTargetRememberCredentials.TabIndex = 26;
      this.checkBoxTargetRememberCredentials.Text = "Remember credentials";
      this.checkBoxTargetRememberCredentials.UseVisualStyleBackColor = true;
      // 
      // textBoxTargetPassword
      // 
      this.textBoxTargetPassword.Location = new System.Drawing.Point(637, 257);
      this.textBoxTargetPassword.Name = "textBoxTargetPassword";
      this.textBoxTargetPassword.Size = new System.Drawing.Size(293, 22);
      this.textBoxTargetPassword.TabIndex = 25;
      // 
      // textBoxTargetName
      // 
      this.textBoxTargetName.Location = new System.Drawing.Point(637, 227);
      this.textBoxTargetName.Name = "textBoxTargetName";
      this.textBoxTargetName.Size = new System.Drawing.Size(293, 22);
      this.textBoxTargetName.TabIndex = 24;
      // 
      // labelTargetPassword
      // 
      this.labelTargetPassword.AutoSize = true;
      this.labelTargetPassword.Location = new System.Drawing.Point(533, 257);
      this.labelTargetPassword.Name = "labelTargetPassword";
      this.labelTargetPassword.Size = new System.Drawing.Size(69, 17);
      this.labelTargetPassword.TabIndex = 23;
      this.labelTargetPassword.Text = "Password";
      // 
      // labelTargetUserName
      // 
      this.labelTargetUserName.AutoSize = true;
      this.labelTargetUserName.Location = new System.Drawing.Point(533, 227);
      this.labelTargetUserName.Name = "labelTargetUserName";
      this.labelTargetUserName.Size = new System.Drawing.Size(79, 17);
      this.labelTargetUserName.TabIndex = 22;
      this.labelTargetUserName.Text = "User Name";
      // 
      // comboBoxTargetAuthentication
      // 
      this.comboBoxTargetAuthentication.FormattingEnabled = true;
      this.comboBoxTargetAuthentication.Location = new System.Drawing.Point(637, 197);
      this.comboBoxTargetAuthentication.Name = "comboBoxTargetAuthentication";
      this.comboBoxTargetAuthentication.Size = new System.Drawing.Size(293, 24);
      this.comboBoxTargetAuthentication.TabIndex = 21;
      this.comboBoxTargetAuthentication.Text = "Authentication";
      // 
      // labelTargetAuthentication
      // 
      this.labelTargetAuthentication.AutoSize = true;
      this.labelTargetAuthentication.Location = new System.Drawing.Point(533, 197);
      this.labelTargetAuthentication.Name = "labelTargetAuthentication";
      this.labelTargetAuthentication.Size = new System.Drawing.Size(98, 17);
      this.labelTargetAuthentication.TabIndex = 20;
      this.labelTargetAuthentication.Text = "Authentication";
      // 
      // labelTargetServer
      // 
      this.labelTargetServer.AutoSize = true;
      this.labelTargetServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelTargetServer.Location = new System.Drawing.Point(530, 112);
      this.labelTargetServer.Name = "labelTargetServer";
      this.labelTargetServer.Size = new System.Drawing.Size(56, 17);
      this.labelTargetServer.TabIndex = 19;
      this.labelTargetServer.Text = "Server";
      // 
      // comboBoxTargetSource
      // 
      this.comboBoxTargetSource.FormattingEnabled = true;
      this.comboBoxTargetSource.Location = new System.Drawing.Point(533, 145);
      this.comboBoxTargetSource.Name = "comboBoxTargetSource";
      this.comboBoxTargetSource.Size = new System.Drawing.Size(366, 24);
      this.comboBoxTargetSource.TabIndex = 18;
      this.comboBoxTargetSource.Text = "Server";
      // 
      // labelTargetOperation
      // 
      this.labelTargetOperation.AutoSize = true;
      this.labelTargetOperation.Location = new System.Drawing.Point(530, 32);
      this.labelTargetOperation.Name = "labelTargetOperation";
      this.labelTargetOperation.Size = new System.Drawing.Size(50, 17);
      this.labelTargetOperation.TabIndex = 17;
      this.labelTargetOperation.Text = "Target";
      // 
      // comboBoxTargetDatabaseTarget
      // 
      this.comboBoxTargetDatabaseTarget.FormattingEnabled = true;
      this.comboBoxTargetDatabaseTarget.Location = new System.Drawing.Point(532, 74);
      this.comboBoxTargetDatabaseTarget.Name = "comboBoxTargetDatabaseTarget";
      this.comboBoxTargetDatabaseTarget.Size = new System.Drawing.Size(293, 24);
      this.comboBoxTargetDatabaseTarget.TabIndex = 16;
      this.comboBoxTargetDatabaseTarget.Text = "Database";
      // 
      // buttonCompareSave
      // 
      this.buttonCompareSave.Location = new System.Drawing.Point(46, 505);
      this.buttonCompareSave.Name = "buttonCompareSave";
      this.buttonCompareSave.Size = new System.Drawing.Size(88, 37);
      this.buttonCompareSave.TabIndex = 31;
      this.buttonCompareSave.Text = "Save";
      this.buttonCompareSave.UseVisualStyleBackColor = true;
      // 
      // buttonCompareSaveAs
      // 
      this.buttonCompareSaveAs.Location = new System.Drawing.Point(148, 505);
      this.buttonCompareSaveAs.Name = "buttonCompareSaveAs";
      this.buttonCompareSaveAs.Size = new System.Drawing.Size(95, 37);
      this.buttonCompareSaveAs.TabIndex = 32;
      this.buttonCompareSaveAs.Text = "Save as ...";
      this.buttonCompareSaveAs.UseVisualStyleBackColor = true;
      // 
      // buttonCompareToRightArrow
      // 
      this.buttonCompareToRightArrow.Location = new System.Drawing.Point(420, 505);
      this.buttonCompareToRightArrow.Name = "buttonCompareToRightArrow";
      this.buttonCompareToRightArrow.Size = new System.Drawing.Size(59, 37);
      this.buttonCompareToRightArrow.TabIndex = 33;
      this.buttonCompareToRightArrow.Text = "-->";
      this.buttonCompareToRightArrow.UseVisualStyleBackColor = true;
      // 
      // buttonCompareToRightAndLeftArrow
      // 
      this.buttonCompareToRightAndLeftArrow.Location = new System.Drawing.Point(489, 505);
      this.buttonCompareToRightAndLeftArrow.Name = "buttonCompareToRightAndLeftArrow";
      this.buttonCompareToRightAndLeftArrow.Size = new System.Drawing.Size(46, 37);
      this.buttonCompareToRightAndLeftArrow.TabIndex = 34;
      this.buttonCompareToRightAndLeftArrow.Text = "<-->";
      this.buttonCompareToRightAndLeftArrow.UseVisualStyleBackColor = true;
      // 
      // buttonCompareToLeftArrow
      // 
      this.buttonCompareToLeftArrow.Location = new System.Drawing.Point(549, 505);
      this.buttonCompareToLeftArrow.Name = "buttonCompareToLeftArrow";
      this.buttonCompareToLeftArrow.Size = new System.Drawing.Size(53, 37);
      this.buttonCompareToLeftArrow.TabIndex = 35;
      this.buttonCompareToLeftArrow.Text = "<--";
      this.buttonCompareToLeftArrow.UseVisualStyleBackColor = true;
      // 
      // buttonCompareCompareNow
      // 
      this.buttonCompareCompareNow.BackColor = System.Drawing.Color.RoyalBlue;
      this.buttonCompareCompareNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonCompareCompareNow.ForeColor = System.Drawing.Color.White;
      this.buttonCompareCompareNow.Location = new System.Drawing.Point(679, 504);
      this.buttonCompareCompareNow.Name = "buttonCompareCompareNow";
      this.buttonCompareCompareNow.Size = new System.Drawing.Size(146, 37);
      this.buttonCompareCompareNow.TabIndex = 36;
      this.buttonCompareCompareNow.Text = "Compare now";
      this.buttonCompareCompareNow.UseVisualStyleBackColor = false;
      // 
      // buttonCompareCompareNowCancel
      // 
      this.buttonCompareCompareNowCancel.Location = new System.Drawing.Point(842, 505);
      this.buttonCompareCompareNowCancel.Name = "buttonCompareCompareNowCancel";
      this.buttonCompareCompareNowCancel.Size = new System.Drawing.Size(146, 37);
      this.buttonCompareCompareNowCancel.TabIndex = 37;
      this.buttonCompareCompareNowCancel.Text = "Cancel";
      this.buttonCompareCompareNowCancel.UseVisualStyleBackColor = true;
      // 
      // FormDatabaseConnexion
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1058, 600);
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
    private System.Windows.Forms.ComboBox comboBoxSourceDatabaseSource;
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
    private System.Windows.Forms.Button buttonTargetCreate;
    private System.Windows.Forms.Button buttonTargetRefresh;
    private System.Windows.Forms.Label labelTargetDatabase;
    private System.Windows.Forms.ComboBox comboBoxTargetDatabase;
    private System.Windows.Forms.CheckBox checkBoxTargetRememberCredentials;
    private System.Windows.Forms.TextBox textBoxTargetPassword;
    private System.Windows.Forms.TextBox textBoxTargetName;
    private System.Windows.Forms.Label labelTargetPassword;
    private System.Windows.Forms.Label labelTargetUserName;
    private System.Windows.Forms.ComboBox comboBoxTargetAuthentication;
    private System.Windows.Forms.Label labelTargetAuthentication;
    private System.Windows.Forms.Label labelTargetServer;
    private System.Windows.Forms.ComboBox comboBoxTargetSource;
    private System.Windows.Forms.Label labelTargetOperation;
    private System.Windows.Forms.ComboBox comboBoxTargetDatabaseTarget;
    private System.Windows.Forms.Button buttonCompareCompareNowCancel;
    private System.Windows.Forms.Button buttonCompareCompareNow;
    private System.Windows.Forms.Button buttonCompareToLeftArrow;
    private System.Windows.Forms.Button buttonCompareToRightAndLeftArrow;
    private System.Windows.Forms.Button buttonCompareToRightArrow;
    private System.Windows.Forms.Button buttonCompareSaveAs;
    private System.Windows.Forms.Button buttonCompareSave;
  }
}