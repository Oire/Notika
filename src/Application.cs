using System;
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
                if (dbnf.ShowDialog() == DialogResult.OK)
                    logger.Info("Database does not exist, creating file.");
                try {
                    SQLiteConnection.CreateFile(Config.database.location);
                } catch (Exception e) {
                    logger.Fatal("Unable to create database file at {0}", Config.database.location);
                }
            }
			System.Windows.Forms.Application.Run(new MainForm());
		}
	}
}