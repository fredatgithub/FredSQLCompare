
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
      this.labelSource = new System.Windows.Forms.Label();
      this.comboBoxDatabaseSource = new System.Windows.Forms.ComboBox();
      this.tabPageTableMapping = new System.Windows.Forms.TabPage();
      this.tabPageOwnerMapping = new System.Windows.Forms.TabPage();
      this.tabPageOptions = new System.Windows.Forms.TabPage();
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
      this.tabPageDataSources.Controls.Add(this.comboBoxServerSource);
      this.tabPageDataSources.Controls.Add(this.labelSource);
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
      // labelSource
      // 
      this.labelSource.AutoSize = true;
      this.labelSource.Location = new System.Drawing.Point(41, 32);
      this.labelSource.Name = "labelSource";
      this.labelSource.Size = new System.Drawing.Size(53, 17);
      this.labelSource.TabIndex = 1;
      this.labelSource.Text = "Source";
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
    private System.Windows.Forms.Label labelSource;
    private System.Windows.Forms.ComboBox comboBoxDatabaseSource;
  }
}