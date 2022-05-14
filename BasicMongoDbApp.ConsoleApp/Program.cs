using BasicMongoDbApp.ConsoleApp.Models;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System.Reflection;

Console.WriteLine("Hello, World!");

IConfiguration configuration = new ConfigurationBuilder()
    .AddUserSecrets(Assembly.GetExecutingAssembly(), true)
    .Build();

var connectionString = configuration["mongoDb:ConnectionString"];

var client = new MongoClient(connectionString);

var db = client.GetDatabase("test");

var books = db.GetCollection<Book>("book").AsQueryable();
