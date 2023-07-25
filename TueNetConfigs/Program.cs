// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.Configuration;

var config = new ConfigurationBuilder()
    .AddJsonFile("config.json")
    .AddCommandLine(args)
    .Build();

Console.WriteLine($"Hello, World! {config["yeet"]}");
