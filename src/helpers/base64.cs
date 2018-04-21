using System;
using System.Text;
using System.Collections.Generic;

namespace Oire.Notika.Helpers {

	/// <summary>
	/// This class encodes to and decodes from URL-safe base64.
	/// For implementation in PHP see https://github.com/Oire/Base64.
	/// </summary>
	public static class Base64 {

		///  <summary>
		///  Encodes a byte array into URL-safe base64.
		/// </summary>
		///  <param name="data">The data to be encoded.</param>
		///  <param name="replaceEquals">Whether to replace the <c>=</c> signs upon converting into base64. If set to <c>true</c>, <c>=</c> signs will be replaced by tildes (<c>~</c>); if set to <c>false</c> (default), <c>=</c> signs will be truncated from the base64 output.</param>
		///  <returns>A base64 encoded string on success or <c>null</c> on failure.</returns>
		public static string encode(byte[] data, bool replaceEquals = false) {
			string encoded;

			if (data?.Length == 0) {
				throw new ArgumentNullException("Data to be encoded cannot be null or empty");
			}

			try {
				encoded = Convert.ToBase64String(data);
				return encoded;
			} catch (Exception e) {
				throw new InvalidOperationException(String.Format("Failed to encode to base64: {0}", e.Message));
			}
		}

		///  <summary>
		///  Encodes a UTF8-encoded string into URL-safe base64.
		/// </summary>
		///  <param name="data">The data to be encoded. Note that if the original string was not encoded in UTF-8, that might yield unpredictable results.</param>
		///  <param name="replaceEquals">Whether to replace the <c>=</c> signs upon converting into base64. If set to <c>true</c>, <c>=</c> signs will be replaced by tildes (<c>~</c>); if set to <c>false</c> (default), <c>=</c> signs will be truncated from the base64 output.</param>
		///  <returns>A base64 encoded string on success or <c>null</c> on failure.</returns>
		public static string encode(string data, bool replaceEquals = false) {
			byte[] bytes;
			string encoded;

			if (String.IsNullOrWhiteSpace(data)) {
				throw new ArgumentNullException("Data to be encoded cannot be null or empty");
			}

			try {
				bytes = Encoding.UTF8.GetBytes(data);
			} catch(Exception e) {
				throw new InvalidOperationException(String.Format("Unable to transform data into a byte array: {0}", e.Message));
			}
			try {
				encoded = Convert.ToBase64String(bytes);
				return encoded;
			} catch (Exception e) {
				throw new InvalidOperationException(String.Format("Failed to encode to base64: {0}", e.Message));
			}
		}

		///  <summary>
		///  Decodes a URL-safe base64 string into a byte array.
		/// </summary>
		///  <param name="data">The base64 string to be decoded.</param>
		///  <returns>The original data decoded from base64 as a byte array.</returns>
		public static byte[] decode(string data) {
			byte[] decoded;

			if (String.IsNullOrWhiteSpace(data)) {
				throw new ArgumentNullException("The data to decode cannot be null or empty.");
			}

			try {
				decoded = Convert.FromBase64String(data);
				return decoded;
			} catch (Exception e) {
				throw new InvalidOperationException(String.Format("Failed to decode from base64: {0}", e.Message));
			}
		}

		///  <summary>
		///  Decodes a URL-safe base64 string into a UTF-8 string.
		/// </summary>
		///  <param name="data">The base64 string to be decoded.</param>
		///  <returns>The original data decoded from base64 as a UTF-8 string. Note that if the original data was not encoded into UTF-8, that might yield unpredictable results.</returns>
		public static string decodeToString(string data) {
			byte[] decodedArr;
			string decoded;

			if (String.IsNullOrWhiteSpace(data)) {
				throw new ArgumentNullException("The data to decode cannot be null or empty.");
			}

			try {
				decodedArr = Convert.FromBase64String(data);
			} catch (Exception e) {
				throw new InvalidOperationException(String.Format("Failed to decode from base64: {0}", e.Message));
			}

			try {
				decoded = Encoding.UTF8.GetString(decodedArr);
				return decoded;
			} catch(Exception e) {
				throw new InvalidOperationException(String.Format("Unable to transform decoded byte array into a string: {0}", e.Message));
			}
		}
	}
}