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
	}
}