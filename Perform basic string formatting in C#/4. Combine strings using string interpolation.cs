string firstName = "Bob";
string message = $"Hello {firstName}!";
Console.WriteLine(message);

string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");

//In this example, the $ symbol allows you to reference the projectName variable inside the braces, while the @ symbol allows you to use the unescaped \ character.