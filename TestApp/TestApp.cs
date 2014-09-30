using System;
using System.Windows.Forms;
using SparkleDotNET;

namespace TestApp
{
    public partial class TestApp : Form
    {
        private SUUpdater updater = null;
        public TestApp()
        {
            InitializeComponent();

            updater = SUUpdater.SharedUpdater();
        }

        private void checkForUpdateButton_Click(object sender, EventArgs e)
        {
            updater.CheckForUpdates();
        }
    }
}
