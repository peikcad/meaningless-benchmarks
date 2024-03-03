using MeaninglessBenchmarks;

Console.WriteLine("Executing...");

var results = new List<Result>(60);

for (var i = 0; i < 20; i++)
{
    results.AddRange(
        StringIsEmpty.Execute(new [] {new Scenario("Null", null!), new Scenario("Empty", ""), new Scenario("Whitespace", " ")}));
}

var groups = results.GroupBy(r => r.Scenario).ToArray();

Console.WriteLine("When string is [null]");
Console.WriteLine(" IsNullOrEmptyPattern: {0}", groups
    .Where(g => g.Key == "Null")
    .SelectMany(g => g)
    .SelectMany(r => r.Records)
    .Where(r => r.Key == "IsNullOrEmptyPattern")
    .Average(r => r.Value));
Console.WriteLine(" IsNullOrEmpty: {0}", groups
    .Where(g => g.Key == "Null")
    .SelectMany(g => g)
    .SelectMany(r => r.Records)
    .Where(r => r.Key == "IsNullOrEmpty")
    .Average(r => r.Value));
Console.WriteLine(" IsNullOrWhiteSpacePattern: {0}", groups
    .Where(g => g.Key == "Null")
    .SelectMany(g => g)
    .SelectMany(r => r.Records)
    .Where(r => r.Key == "IsNullOrWhiteSpacePattern")
    .Average(r => r.Value));
Console.WriteLine(" IsNullOrWhiteSpace: {0}", groups
    .Where(g => g.Key == "Null")
    .SelectMany(g => g)
    .SelectMany(r => r.Records)
    .Where(r => r.Key == "IsNullOrWhiteSpace")
    .Average(r => r.Value));
 
Console.WriteLine("When string is [Empty]");
Console.WriteLine(" IsNullOrEmptyPattern: {0}", groups
    .Where(g => g.Key == "Empty")
    .SelectMany(g => g)
    .SelectMany(r => r.Records)
    .Where(r => r.Key == "IsNullOrEmptyPattern")
    .Average(r => r.Value));
Console.WriteLine(" IsNullOrEmpty: {0}", groups
    .Where(g => g.Key == "Empty")
    .SelectMany(g => g)
    .SelectMany(r => r.Records)
    .Where(r => r.Key == "IsNullOrEmpty")
    .Average(r => r.Value));
Console.WriteLine(" IsNullOrWhiteSpacePattern: {0}", groups
    .Where(g => g.Key == "Empty")
    .SelectMany(g => g)
    .SelectMany(r => r.Records)
    .Where(r => r.Key == "IsNullOrWhiteSpacePattern")
    .Average(r => r.Value));
Console.WriteLine(" IsNullOrWhiteSpace: {0}", groups
    .Where(g => g.Key == "Empty")
    .SelectMany(g => g)
    .SelectMany(r => r.Records)
    .Where(r => r.Key == "IsNullOrWhiteSpace")
    .Average(r => r.Value));
    
Console.WriteLine("When string is [Whitespace]");
Console.WriteLine(" IsNullOrEmptyPattern: {0}", groups
    .Where(g => g.Key == "Whitespace")
    .SelectMany(g => g)
    .SelectMany(r => r.Records)
    .Where(r => r.Key == "IsNullOrEmptyPattern")
    .Average(r => r.Value));
Console.WriteLine(" IsNullOrEmpty: {0}", groups
    .Where(g => g.Key == "Whitespace")
    .SelectMany(g => g)
    .SelectMany(r => r.Records)
    .Where(r => r.Key == "IsNullOrEmpty")
    .Average(r => r.Value));
Console.WriteLine(" IsNullOrWhiteSpacePattern: {0}", groups
    .Where(g => g.Key == "Whitespace")
    .SelectMany(g => g)
    .SelectMany(r => r.Records)
    .Where(r => r.Key == "IsNullOrWhiteSpacePattern")
    .Average(r => r.Value));
Console.WriteLine(" IsNullOrWhiteSpace: {0}", groups
    .Where(g => g.Key == "Whitespace")
    .SelectMany(g => g)
    .SelectMany(r => r.Records)
    .Where(r => r.Key == "IsNullOrWhiteSpace")
    .Average(r => r.Value));