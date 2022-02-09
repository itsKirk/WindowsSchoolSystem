using SchoolSystem.Core.Domain.Factory;
using SchoolSystem.Core.Screens.BluePrints;
using SchoolSystem.Library.Core.DTOs;
using SchoolSystem.Repository.Initialization;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SchoolSystem.Core.Screens
{
    public partial class MainForm : BaseForm
    {
        internal static (
          List<string> EducationLevels,
          List<string> Employers,
          List<string> EmploymentTypes,
          List<string> Genders,
          List<string> Religions,
          List<string> Titles,
          Logo Logo) Initialization;
        public MainForm()
        {
            InitializeComponent();
            PreparePanels();
            Initialization = InitializeThings();
        }
        private void PreparePanels()
        {
            ControlPanel.BackColor = Color.SkyBlue;
            MainMenu.BackColor = ControlPanel.BackColor;
            MainPanel.BackColor = Color.FloralWhite;
            MainMenu.ForeColor = Color.WhiteSmoke;
        }
        private (
          List<string>,
          List<string>,
          List<string>,
          List<string>,
          List<string>,
          List<string>,
          Logo) InitializeThings()
        {
            return
              (
                Factory.EducationLevels(),
                Factory.Employers(),
                Factory.EmploymentTypes(),
                Factory.Genders(),
                Factory.Religions(),
                Factory.Titles(),
                StartUp.GetLogo()
              );
        }
        private void SettingsButton_Click(object sender, System.EventArgs e)
        {
            if (!(MainPanel.Controls.Count > 0))
            {
                MainPanel.Controls.Add(new SettingsControl()
                {
                    BackColor = Color.AntiqueWhite,
                    Dock = DockStyle.Fill
                });
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
