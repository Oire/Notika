using System;
using System.IO;
using System.Windows.Forms;
using SharpConfig;

namespace Oire.Notika {
    public static class Config {
		private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
		public static readonly string CONFIG_DIR = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"Oire\Notika");
		public static readonly string USER_NAME = Environment.UserName[0].ToString().ToUpper() + Environment.UserName.Substring(1);
		private static readonly string CONFIG_PATH = Path.Combine(CONFIG_DIR, "notika.cfg");
		
		public static Config.General general;
		public static Config.Database database;
		private static Configuration config;

		#region Config Section Classes
		public class General {
			public string language { get; set; } = "system";
		}

		public class Database {
			public string location { get; set; } = String.Format(Path.Combine(CONFIG_DIR, "{0}.ndb"), Environment.UserName);
			public bool usePassword { get; set; } = false;
			public string userName { get; set; } = USER_NAME;
			public string password { get; set; } = "";
		}
		#endregion

		public static void Load() {
			try {
				config = Configuration.LoadFromFile(CONFIG_PATH);
				general = config["General"].ToObject<General>();
				database = config["Database"].ToObject<Database>();
			} catch (FileNotFoundException) {
				logger.Info("Config file not found, creating default configuration.");
				config = new Configuration();
				general = new Config.General();
				database = new Config.Database();
				config.Add(Section.FromObject("General", general));
				config.Add(Section.FromObject("Database", database));
				try {
					if (!Directory.Exists(CONFIG_DIR)) {
						logger.Info("Configuration directory does not exist, creating new folder.");
						Directory.CreateDirectory(CONFIG_DIR);
					}
					config.SaveToFile(CONFIG_PATH);
				} catch (Exception e) {
					logger.Fatal("Unable to save configuration to {0}: {1}", CONFIG_PATH, e.Message);
					DialogResult msg = MessageBox.Show("Unable to save configuration. Please contact the developer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			} catch (Exception e) {
				logger.Fatal("Unable to load configuration from {0}: {1}", CONFIG_PATH, e.Message);
				DialogResult msg = MessageBox.Show("Unable to load configuration. Please contact the developer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		public static void Save() {
			logger.Info("Saving configuration.");
			try {
				config.SaveToFile(CONFIG_PATH);
			} catch(Exception e) {
				logger.Fatal("Unable to save configuration to {0}: {1}", CONFIG_PATH, e.Message);
				DialogResult msg = MessageBox.Show("Unable to save configuration. Please contact the developer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
	}
}
