
using FlyweightPatternHelloWorld;

Console.WriteLine("Let's try out the Flyweight pattern!");

FlyweightFactory factory = new();
Client client = new(factory);

client.Operation("Hello");
client.Operation("Hi");
client.Operation("World");



