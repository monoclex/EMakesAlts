using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


///
//
//The MIT License (MIT)
//
//Copyright (c) 2016 SirJosh3917
//
//Permission is hereby granted, free of charge, to any person obtaining a
//copy of this software and associated documentation files (the "Software"),
//to deal in the Software without restriction, including without limitation
//the rights to use, copy, modify, merge, publish, distribute, sublicense,
//and/or sell copies of the Software, and to permit persons to whom the
//Software is furnished to do so, subject to the following conditions:
//
//The above copyright notice and this permission notice shall be included
//in all copies or substantial portions of the Software.
//
//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS
//OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
//THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR
//OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
//ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
//OTHER DEALINGS IN THE SOFTWARE.
//
///

namespace System.IO.Advanced
{
	public class IO
	{
		#region Variables
		public char[] IllegalFileChars { get { return new char[] { '\\', '/', ':', '*', '?', '<', '>', '|', '\r', '\n' }; } set { } }
		public static char[] IllegalFileCharsStatic { get { return new char[] { '\\', '/', ':', '*', '?', '<', '>', '|', '\r', '\n' }; } set { } }
		private string PrvFileName = "";
		private string PrvFilePath = "";
		#endregion

		#region Constructor(s)
		/// <summary>
		/// Create an IO to do your dirty file work
		/// </summary>
		/// <param name="FileNameAndPath">The full file name and path</param>
		public IO(string FileNameAndPath, bool FixErrorsIfPossible = false)
		{
			bool ErrorsFixed = false;
			FileNameAndPath.Replace('/', '\\');

			//Truncate ending slashes
			while (FileNameAndPath.EndsWith("\\"))
			{
				FileNameAndPath.Substring(0, FileNameAndPath.Length - 2);
			}

			if (HasIllegalCharecters(FileNameAndPath, false))
			{
				if (!FixErrorsIfPossible)
				{
					throw new IllegalCharecters();
				}
				else
				{
					FileNameAndPath = CleanIllegalCharecters(FileNameAndPath, false);
					if (HasIllegalCharecters(FileNameAndPath, false))
					{
						throw new IllegalCharecters();
					}
				}
			}

			FileName = FileNameAndPath.Split('\\')[FileNameAndPath.Split('\\').Length - 1];
			FilePath = FileNameAndPath.Substring(0, FileNameAndPath.Length - FileName.Length - 1);

			//Check if file exists
			if (!File.Exists(FileNameAndPath))
			{
				if (FixErrorsIfPossible)
				{
					//We'll let this throw the errors

					try
					{
						File.Create(FileNameAndPath);
					}
					catch (DirectoryNotFoundException e)
					{
						Directory.CreateDirectory(FilePath);
						File.Create(FileNameAndPath);
					}
				}
				else
				{
					throw new System.IO.FileNotFoundException("The file was not found. Please make sure it exists.");
				}
			}

			FileName = FileNameAndPath.Split('\\')[FileNameAndPath.Split('\\').Length - 1];
			FilePath = FileNameAndPath.Substring(0, FileNameAndPath.Length - FileName.Length - 1);
		}
		#endregion

		#region File Properties
		public string FilePath
		{
			get
			{
				return PrvFilePath;
			}
			set
			{
				if (!value.Contains('/') && !value.Contains('\\'))
				{
					throw new BlankFileName("The string provided had no slashes ( / \\ )");
				}
				else
				{
					value.Replace('/', '\\');
					bool FirstElement = true;

					foreach (string i in value.Split('\\'))
					{
						if (!FirstElement)
						{
							if (i.Length == 0)
							{
								throw new BlankFileName();
							}

							if (HasIllegalCharecters(i))
							{
								throw new IllegalCharecters();
							}

							PrvFilePath = value;
						}
						else
						{
							FirstElement = false;
						}
					}

					PrvFilePath = value + "\\";
				}

			}
		}
		public string FileName
		{
			get
			{
				return PrvFileName;
			}
			set
			{
				if (HasIllegalCharecters(value))
				{
					throw new IllegalCharecters();
				}

				if (value.Length == 0)
				{
					throw new BlankFileName();
				}

				PrvFileName = value;
			}
		}

		public bool IllegalCharecters
		{
			get
			{
				return HasIllegalCharecters();
			}
			set
			{
				//If we don't want illegal charecters
				if (!value)
				{
					//Remove them
					CleanIllegalCharecters();
				}
			}
		}
		#endregion

		#region General File Code

		public bool HasIllegalCharecters(string CleanString, bool CleanSlashes)
		{
			string Clean = CleanString;
			if (CleanString.Length > 1)
			{
				if (CleanString.Substring(1, 1) == ":")
				{
					Clean = CleanString.Substring(2);
				}
			}
			char[] Check = Clean.ToCharArray();
			foreach (char i in IllegalFileChars)
			{
				if (i == '/' || i == '\\')
				{
					if (CleanSlashes)
					{
						if (Check.Contains(i))
						{
							return true;
						}
					}
				}
				else
				{
					if (Check.Contains(i))
					{
						return true;
					}
				}
			}
			return false;
		}
		public bool HasIllegalCharecters(string Clean)
		{
			return HasIllegalCharecters(Clean, true);
		}
		public bool HasIllegalCharecters()
		{
			return HasIllegalCharecters(FileName);
		}

		public string CleanIllegalCharecters(string Clean, bool CleanSlashes)
		{
			//We only want to do work if we need to
			if (HasIllegalCharecters(Clean))
			{
				List<char> CleanChar = Clean.ToCharArray().ToList<char>();
				foreach (char i in IllegalFileChars)
				{
					if (i == '/' || i == '\\')
					{
						if (!CleanSlashes)
						{
							while (CleanChar.Contains(i))
							{
								CleanChar.Remove(i);
							}
						}
					}
					else
					{
						while (CleanChar.Contains(i))
						{
							CleanChar.Remove(i);
						}
					}
				}
				foreach (char i in CleanChar)
				{
					Clean += i.ToString();
				}
			}
			return Clean;
		}
		public string CleanIllegalCharecters(string Clean)
		{
			return CleanIllegalCharecters(Clean, true);
		}
		public void CleanIllegalCharecters()
		{
			FileName = CleanIllegalCharecters(FileName);
		}

		#endregion

		#region File Saving and Loading

		public string this[string index]
		{
			get
			{
				foreach (string i in File.ReadAllLines(string.Concat(PrvFilePath, PrvFileName)))
				{
					if (i.Contains(":"))
					{
						if (i.Split(':')[0] == index)
						{
							return i.Substring(index.Length + 1);
						}
					}
				}

				throw new DataNotFound();
			}
			set
			{
				int line = 0;
				bool WroteToFile = false;
				bool DidIt = false;

				while (!DidIt)
				{
					try
					{
						foreach (string i in File.ReadAllLines(string.Concat(PrvFilePath, PrvFileName)))
						{
							if (i.Contains(":"))
							{
								if (i.Split(':')[0] == index)
								{
									string[] file = File.ReadAllLines(string.Concat(PrvFilePath, PrvFileName));
									file[line] = string.Concat(index, ":", value);
									File.WriteAllLines(string.Concat(PrvFilePath, PrvFileName), file);
									WroteToFile = true;
									DidIt = true;
								}
							}
							line++;
						}

						if (!WroteToFile)
						{
							string[] file = File.ReadAllLines(string.Concat(PrvFilePath, PrvFileName));
							string[] x = new string[file.Length + 1];
							for (int i = 0; i < file.Length; i++)
								x[i] = file[i];
							x[file.Length] = string.Concat(index, ":", value);
							File.WriteAllLines(string.Concat(PrvFilePath, PrvFileName), x);
							DidIt = true;
						}
					}
					catch
					{

					}
				}
			}
		}

		#endregion

		#region General Static File Code

		public static bool HasIllegalCharectersStatic(string CleanString, bool CleanSlashes)
		{
			string Clean = CleanString;
			if (CleanString.Length > 1)
			{
				if (CleanString.Substring(1, 1) == ":")
				{
					Clean = CleanString.Substring(2);
				}
			}
			char[] Check = Clean.ToCharArray();
			foreach (char i in IllegalFileCharsStatic)
			{
				if (i == '/' || i == '\\')
				{
					if (CleanSlashes)
					{
						if (Check.Contains(i))
						{
							return true;
						}
					}
				}
				else
				{
					if (Check.Contains(i))
					{
						return true;
					}
				}
			}
			return false;
		}
		public static bool HasIllegalCharectersStatic(string Clean)
		{
			return HasIllegalCharectersStatic(Clean, true);
		}

		public static string CleanIllegalCharectersStatic(string Clean, bool CleanSlashes)
		{
			//We only want to do work if we need to
			if (HasIllegalCharectersStatic(Clean))
			{
				List<char> CleanChar = Clean.ToCharArray().ToList<char>();
				foreach (char i in IllegalFileCharsStatic)
				{
					if (i == '/' || i == '\\')
					{
						if (!CleanSlashes)
						{
							while (CleanChar.Contains(i))
							{
								CleanChar.Remove(i);
							}
						}
					}
					else
					{
						while (CleanChar.Contains(i))
						{
							CleanChar.Remove(i);
						}
					}
				}
				foreach (char i in CleanChar)
				{
					Clean += i.ToString();
				}
			}
			return Clean;
		}
		public static string CleanIllegalCharectersStatic(string Clean)
		{
			return CleanIllegalCharectersStatic(Clean, true);
		}

		#endregion
	}

	public class IllegalCharecters : Exception
	{
		public IllegalCharecters(string reason)
			: base(reason)
		{

		}
		public IllegalCharecters()
			: base("The input provided had some illegal charecters.")
		{

		}
	}

	public class BlankFileName : Exception
	{
		public BlankFileName(string reason)
			: base(reason)
		{

		}
		public BlankFileName()
			: base("The string provided was empty.")
		{

		}
	}

	public class DataNotFound : Exception
	{
		public DataNotFound(string reason)
			: base(reason)
		{

		}
		public DataNotFound()
			: base("The data index was not found.")
		{

		}
	}
}
