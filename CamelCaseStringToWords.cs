using System;
using System.Text.RegularExpressions;

public static void Main()
	{
		Console.WriteLine(CamelCaseStringToWords("HomeInsuranceAAA"));
	}

public static string CamelCaseStringToWords(string text) 
	{
		if (text != null && text.Length > 2) 
		{
			return Regex.Replace(text, @"((?<=[a-z])(?=[A-Z]))|((?<=[A-Z])(?=[A-Z][a-z]))", " ");
		}
		else
		{
			return text;
		}
	} 
