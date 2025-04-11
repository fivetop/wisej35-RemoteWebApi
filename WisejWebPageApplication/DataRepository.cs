using System;
using System.IO;
using Wisej.Web;

namespace WisejWebPageApplication
{
	internal class DataRepository
	{
		private static readonly string DATA_PATH = Application.MapPath("data.txt");

		/// <summary>
		/// Retrieves the value from the file (or database).
		/// </summary>
		/// <returns>The data.</returns>
		public static string GetValue()
		{
			try
			{
				return File.ReadAllText(DATA_PATH);
			}
			catch (Exception ex) 
			{
				return String.Empty;
			}
		}

		/// <summary>
		/// Saves a value to the file (or database).
		/// </summary>
		/// <param name="value">The value to save.</param>
		/// <returns>True if the operation succeeded.</returns>
		public static bool SaveValue(string value) 
		{
			try
			{
				File.WriteAllText(DATA_PATH, value);

				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}
	}
}
