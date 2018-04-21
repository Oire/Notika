using System;
using NGettext;

namespace Oire.Notika.Helpers {
	internal class Tr {
		private static readonly ICatalog stringsCatalog = new Catalog("Notika", "./locale");

		public static string _(string text) {
			return stringsCatalog.GetString(text);
		}

		public static string _(string text, params object[] args) {
			return stringsCatalog.GetString(text, args);
		}

		public static string _n(string text, string pluralText, long n) {
			return stringsCatalog.GetPluralString(text, pluralText, n);
		}

		public static string _n(string text, string pluralText, long n, params object[] args) {
			return stringsCatalog.GetPluralString(text, pluralText, n, args);
		}

		public static string _p(string context, string text) {
			return stringsCatalog.GetParticularString(context, text);
		}

		public static string _p(string context, string text, params object[] args) {
			return stringsCatalog.GetParticularString(context, text, args);
		}

		public static string _pn(string context, string text, string pluralText, long n) {
			return stringsCatalog.GetParticularPluralString(context, text, pluralText, n);
		}

		public static string _pn(string context, string text, string pluralText, long n, params object[] args) {
			return stringsCatalog.GetParticularPluralString(context, text, pluralText, n, args);
		}
	}
}