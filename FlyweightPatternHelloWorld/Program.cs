
using System.ComponentModel;
using FlyweightPatternHelloWorld;

Console.WriteLine("Let's try out the Flyweight pattern!");

GlyphFactory factory = new();
DocumentEditor editor = new(factory);

string text = "Hello, Flyweight!";
int x= 10; 
int y = 10; 

foreach (char c in text)
{
    editor.InsertCharacter(c, "Arial", x, y, 12, "Black");
    x += 10;
}

string upperCase = text.ToUpper();

foreach (char c in upperCase)
{
    editor.InsertCharacter(c, "Times New Roman", x, y, 14, "Red");
    x += 10;
}

editor.RenderDocument();