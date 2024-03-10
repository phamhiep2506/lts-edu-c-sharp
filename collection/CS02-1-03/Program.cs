string text = "chao LTS edu";
char[] textChar = text.ToCharArray();

// Anonymous function
Console.WriteLine(textChar.Count(x => x == char.Parse("u")));
