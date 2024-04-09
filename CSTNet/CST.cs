// This project is licensed under the BSD 3-Clause license.
// See the LICENSE file in the project root for more information.
#if NET8_0
using System.Runtime.InteropServices;
#endif

namespace CSTNet;

public static class CST
{
	const char CARET = '^';
	const string LF = "\u000A";
	const string CR = "\u000D";
	const string CRLF = "\u000D\u000A";
	const string LS = "\u2028";

	/// <summary>
	/// Gets the value from the digit-based key.
	/// </summary>
	/// <returns>Returns the entry</returns>
	public static string Parse(string content, int key) => Parse(content, key.ToString());

	/// <summary>
	/// Gets the value from the string-based key.
	/// </summary>
	/// <returns>Returns the entry</returns>
	public static string Parse(string content, string key)
	{
		var entries = NormalizeEntries(content);
		return GetEntry(entries, key);
	}

#if (NET8_0 && DEBUG)
	[UnmanagedCallersOnly(EntryPoint = "parse")]
	public static IntPtr Parse(IntPtr content, IntPtr key)
	{
		// => Parse(Marshal.PtrToStringAnsi(content), Marshal.PtrToStringAnsi(key));
		var entries = NormalizeEntries(Marshal.PtrToStringAnsi(content));
		return Marshal.StringToHGlobalAnsi(GetEntry(entries, Marshal.PtrToStringAnsi(key)));
	}
#endif
	/// <summary>
	/// Normalizes the content by replacing various newline characters with Environment.NewLine and filters out comments.
	/// </summary>
	/// <param name="content">The content to normalize.</param>
	/// <returns>An enumerable of normalized lines.</returns>
	public static IEnumerable<string> NormalizeEntries(string content)
	{
		var newLines = new[] { LF, CR, CRLF, LS };

		content = newLines.Aggregate(content, (current, nl) => current.Replace(nl, Environment.NewLine));

		return content.Split($"{CARET}{Environment.NewLine}", StringSplitOptions.RemoveEmptyEntries)
		.Where(line => !line.StartsWith("//") && !line.StartsWith('#') && !line.StartsWith("/*") && !line.EndsWith("*/"));
	}

	/// <summary>
	/// Retrieves the value for the specified key from the given entries.
	/// </summary>
	/// <param name="entries">The entries to search through.</param>
	/// <param name="key">The key to search for.</param>
	/// <returns>The value for the specified key, or a default string if not found.</returns>
	static string GetEntry(IEnumerable<string> entries, string key)
	{
		// Iterate through the entries.
		foreach (var entry in entries)
		{
			// If the line doesn't start with the key, keep searching.
			if (!entry.StartsWith(key))
				continue;

			// Locate the index of the caret character.
			var startIndex = entry.IndexOf(CARET);
			// Get the line from the caret character to the end of the string.
			var line = entry[startIndex..];

			// Return the line with the caret characters trimmed.
			return line.TrimStart(CARET).TrimEnd(CARET);
		}

		// If no entry is found, return a default string.
		return "***MISSING***";
	}

}


