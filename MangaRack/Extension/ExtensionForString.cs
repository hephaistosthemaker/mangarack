﻿// ======================================================================
// This source code form is subject to the terms of the Mozilla Public
// License, version 2.0. If a copy of the MPL was not distributed with 
// this file, you can obtain one at http://mozilla.org/MPL/2.0/.
// ======================================================================
using System.IO;
using System.Linq;

namespace MangaRack {
	/// <summary>
	/// Represents the class providing extensions for the String class.
	/// </summary>
	static class ExtensionForString {
		#region Methods
		/// <summary>
		/// Remove invalid path characters.
		/// </summary>
		/// <param name="LocalPath">The local path.</param>
		public static string InvalidatePath(this string LocalPath) {
			// Remove invalid characters for a path.
			return string.IsNullOrEmpty(LocalPath) ? LocalPath : string.Join(null, LocalPath.Where(x => !Path.GetInvalidFileNameChars().Contains(x)).Select(x => x.ToString()).ToArray());
		}
		#endregion
	}
}