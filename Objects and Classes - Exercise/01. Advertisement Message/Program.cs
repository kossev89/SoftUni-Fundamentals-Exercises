﻿string[] phrases = {"Excellent product.", "Such a great product.",
        "I always use that product.", "Best product of its category.", "Exceptional product.",
    "I can't live without this product."};
string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!",
    "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

int numberOfMessages = int.Parse(Console.ReadLine());
Random genarate = new Random();

for (int i = 0; i < numberOfMessages; i++)
{
    string phrase = phrases[genarate.Next(phrases.Length)];
    string @event = events[genarate.Next(events.Length)];
    string author = authors[genarate.Next(authors.Length)];
    string city = cities[genarate.Next(cities.Length)];
    Console.WriteLine($"{phrase} {@event} {author} – {city}.");
}