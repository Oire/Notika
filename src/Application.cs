﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using Oire.Notika.Dialogs;
using Oire.Notika.Helpers;
using static Oire.Notika.Helpers.Tr;

namespace Oire.Notika {
	static class Application {
		private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			System.Windows.Forms.Application.EnableVisualStyles();
			System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
			Config.Load();
            			if (!File.Exists(Config.database.location)) {
            				DatabaseNotFound dbnf = new Dialogs.DatabaseNotFound();
				dbnf.ShowDialog();
				// logger.Info("Database does not exist, creating file.");
				// SQLiteConnection.CreateFile(Config.database.location);
			}
			System.Windows.Forms.Application.Run(new MainForm());
		}
	}
}