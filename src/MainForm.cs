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

namespace Oire.Notika {
	public partial class MainForm: Form {
		private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

		public MainForm() {
			InitializeComponent();
		}
	}
}