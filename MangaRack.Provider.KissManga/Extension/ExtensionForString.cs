﻿// ======================================================================
// This source code form is subject to the terms of the Mozilla Public
// License, version 2.0. If a copy of the MPL was not distributed with 
// this file, you can obtain one at http://mozilla.org/MPL/2.0/.
// ======================================================================

namespace MangaRack.Provider.KissManga {
	/// <summary>
	/// Represents the class providing extensions for the String class.
	/// </summary>
	static class ExtensionForString {
		#region Methods
		/// <summary>
		/// Convert an alphabetic suffix to a numeric suffix.
		/// </summary>
		/// <param name="Value">The value.</param>
		public static string AlphabeticToNumeric(this string Value) {
			// Retrieve the alphabetic value.
			char Alphabetic = Value.ToLowerInvariant()[Value.Length - 1];
			// Check if the presumed alphabetic value is actually alphabetic.
			if (!char.IsDigit(Alphabetic)) {
				// Remove the alphabetic value.
				Value = Value.Substring(0, Value.Length - 1);
				// Check if the value does not values behind the digit.
				if (Value.IndexOf('.') == -1) {
					// Append the digit separator.
					Value += '.';
				}
				// Convert the alphabetic value to numeric and append it.
				Value += ((int) Alphabetic - 96).ToString();
			}
			// Return the value.
			return Value;
		}

		/// <summary>
		/// Remove characters before and including the first occurrence of the subject.
		/// </summary>
		/// <param name="Value">The value.</param>
		/// <param name="Subject">The subject.</param>
		public static string RemoveToIncluding(this string Value, string Subject) {
			// Declare the index.
			int Index;
			// Remove characters before and including the first occurrence of the subject.
			return (Index = Value.IndexOf(Subject)) != -1 ? Value.Substring(Index + Subject.Length) : Value;
		}

		/// <summary>
		/// Returns a new string in which all occurrences of a specified string in the current instance are replaced with another specified string.
		/// </summary>
		/// <param name="Value">The value.</param>
		/// <param name="OldValue">The string to be replaced.</param>
		/// <param name="NewValue">The string to replace all occurrences of OldValue.</param>
		public static string ReplaceWhileWithDigit(this string Value, string OldValue, string NewValue) {
			// Declare the index.
			int Index;
			// Iterate while the old value is available.
			while ((Index = Value.IndexOf(OldValue)) != -1 && (Index + OldValue.Length > Value.Length || char.IsDigit(Value[Index + OldValue.Length]))) {
				// Replace the old value with the new value.
				Value = Value.Replace(OldValue, NewValue);
			}
			// Return the modified value.
			return Value;
		}
		#endregion
	}
}