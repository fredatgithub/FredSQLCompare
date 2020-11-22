using FredSQLCompare.Properties;
using FredSQLCompare.View;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

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

      GetWindowValue();
      DisplayTitle();
      LoadComboboxes();
    }

    private void LoadComboboxes()
    {
      // TODO
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

    private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
    {
      // You can place this code on File.Quit Menu method if you have one or here (window closing method)
      SaveWindowValue();
    }

    private void SaveWindowValue()
    {
      Settings.Default.WindowHeight = Height;
      Settings.Default.WindowWidth = Width;
      Settings.Default.WindowLeft = Left;
      Settings.Default.WindowTop = Top;
      Settings.Default.Save();
    }

    private void GetWindowValue()
    {
      Width = Settings.Default.WindowWidth;
      Height = Settings.Default.WindowHeight;
      Top = Settings.Default.WindowTop < 0 ? 0 : Settings.Default.WindowTop;
      Left = Settings.Default.WindowLeft < 0 ? 0 : Settings.Default.WindowLeft;
    }

    private void DisplayTitle()
    {
      Assembly assembly = Assembly.GetExecutingAssembly();
      FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
      Text += string.Format(" V{0}.{1}.{2}.{3}", fvi.FileMajorPart, fvi.FileMinorPart, fvi.FileBuildPart, fvi.FilePrivatePart);
    }
  }
}
