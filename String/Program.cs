// See https://aka.ms/new-console-template for more information

var phrase = " C# is a modern and versatile programming language. " +
             "With it I can create web applications, libraries, " +
             "games, machine learning, internet of things and etc... ";

//Length
var size = phrase.Length;

//Empty
var empty = string.Empty;

//ToLower / ToUpper
var lower = phrase.ToLower();
var upper = phrase.ToUpper();

//Split
var split = phrase.Split(" ");

//Trim / TrimEnd / TrimStart
var trim = phrase.Trim();
var trimStart = phrase.TrimStart();
var trimEnd = phrase.TrimEnd();

//IsNullOrWhiteSpace
var isNullOrWhiteSpace = string.IsNullOrWhiteSpace(phrase);

//Replace
var replace = phrase.Replace(" ", "");

//IndexOf
var indexOf = phrase.IndexOf("C#");

//LastIndexOf
var lastIndexOf = phrase.LastIndexOf("C#");

//StartsWith
var startsWith = phrase.StartsWith("C#");

//Substring
var indexOfMobile = phrase.IndexOf("Mobile");
var substring = phrase.Substring(indexOfMobile, 3);

//Contains
var contains = phrase.Contains("C#", StringComparison.OrdinalIgnoreCase);
var containsExact = phrase.Contains("C#");