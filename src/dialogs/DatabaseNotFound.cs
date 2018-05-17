using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Oire.Notika.Helpers.Tr;

namespace Oire.Notika.Dialogs {
	public partial class DatabaseNotFound : Form {
		private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

		public DatabaseNotFound() {
			InitializeComponent();
            		}

				private void browse_Click(object sender, EventArgs e) {
			using (OpenFileDialog ofd = new OpenFileDialog()) {
				ofd.InitialDirectory = Config.CONFIG_DIR;
				ofd.AddExtension = true;
				ofd.DefaultExt = "ndb";
                ofd.CheckFileExists = false;
				ofd.Filter = _("Notika database files (*.ndb)|*.ndb|All files (*.*)|*.*");
				ofd.Multiselect = false;
				ofd.RestoreDirectory = true;
				ofd.Title = _("Select Database File");
				if (ofd.ShowDialog() == DialogResult.OK) {
					this.fileName.Text = ofd.FileName;
                    this.fileName.Focus();
				}
			}
		}

		private void ok_Click(object sender, EventArgs e) {
			this.DialogResult = DialogResult.OK;
		}

		private void cancel_Click(object sender, EventArgs e) {
			this.DialogResult = DialogResult.Cancel;
			logger.Info("Database search canceled. Closing window.");
			this.Close();
		}
	}
}