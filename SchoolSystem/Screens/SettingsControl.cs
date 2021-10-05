using SchoolSystem.Core.Domain.Factory;
using SchoolSystem.Library.Core.DTOs;
using SchoolSystem.Repository.Abstractions;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SchoolSystem.Core.Screens
{
  public partial class SettingsControl : UserControl
  {
    private ISettingsRepository repository;
    private Logo Logo;
    public SettingsControl()
    {
      InitializeComponent();
      InitiateItems();
      Logo = MainForm.Initialization.Logo;
      repository = Factory.SettingsRepository();
      SetLogo();
    }
    private void SetLogo()
    {
      if (Logo == null) return;
      var file = Directory.GetFiles(
        Application.StartupPath.Substring(0,
          Application.StartupPath.Length - 10) + @"\Logo\")[0];
      LogoBox.Image = new Bitmap(file);
    }
    private void CloseBox_Click(object sender, System.EventArgs e)
    {
      CloseSettingWindow();
    }
    private void CloseSettingWindow()
    {
      if (MessageBox.Show(@"Are you sure you want to close the settings window?",
        @"Confirm Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
        MessageBoxDefaultButton.Button2) == DialogResult.No) return;
      Parent.Controls.Remove(this);
      Dispose();
    }
    private void InitiateItems()
    {
      LanguageComboBox.SelectedIndex = 0;
      CurrencyComboBox.SelectedIndex = 0;
    }
    private void UploadLogo()
    {
      OFD.InitialDirectory = @"D:\Documents";
      OFD.Title = @"Select Logo to upload.";
      OFD.Filter = @"*.jpg; *.jpeg; *.png;|*.jpg; *.jpeg; *.png";
      OFD.FilterIndex = 1;
      try
      {
        SaveLogo(LogoBox, OFD);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
    private static void CleanLogoDirectory(string fileName)
    {
      var files = Directory.GetFiles(
        Application.StartupPath.Substring(0,
          (Application.StartupPath.Length - 10)) + @"\Logo\");
      if (files.Length < 1) return;
      foreach (var file in files)
      {
        if (!file.EndsWith(fileName))
        {
          File.Delete(file);
        }
      }
    }
    private void SaveLogo(PictureBox box, FileDialog dialog)
    {
      if (dialog.ShowDialog() != DialogResult.OK) return;
      if (!dialog.CheckFileExists) return;
      if (MessageBox.Show(@"This will overwrite the existing logo, continue?", @"Logo",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
      box.Image = new Bitmap(dialog.FileName);
      box.BackgroundImageLayout = ImageLayout.Stretch;
      var fileName = Path.GetFileName(dialog.FileName);
      var folder = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
      File.Copy(dialog.FileName, folder + @"\Logo\" + fileName);
      CleanLogoDirectory(Path.GetFileName(dialog.FileName));
      SaveAndUpdateLogoGlobally(new Logo { FileName = Path.GetFileName(dialog.FileName) });
    }
    private void LogoBox_Click(object sender, EventArgs e)
    {
      UploadLogo();
    }
    private void SaveAndUpdateLogoGlobally(Logo logo)
    {
      repository.SaveLogo(logo);
      MainForm.Initialization.Logo = repository.GetLogo();
    }
    private void LayoutPanel_Paint(object sender, PaintEventArgs e)
    {

    }
  }
}
