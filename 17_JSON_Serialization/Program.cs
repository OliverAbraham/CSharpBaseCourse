using System.Text.Json;


Console.WriteLine("Serializing and deserializing to and from JSON (with built-in function)");


var myData = new MyData();
Console.WriteLine($"\n\nMy data that I want to save:");
Console.WriteLine($"  myData.Name        = '{myData.Name       }'");
Console.WriteLine($"  myData.Description = '{myData.Description}'");
Console.WriteLine($"  myData.Amount      = '{myData.Amount     }'");


Console.WriteLine($"\n\nWriting this data to a file");
var jsonToFile = JsonSerializer.Serialize(myData);
File.WriteAllText("JsonSerializerDemo.dat", jsonToFile);


Console.WriteLine($"\n\nReading data back from file");
var jsonFromFile = File.ReadAllText("JsonSerializerDemo.dat");
Console.WriteLine($"Contents of the file:");
Console.WriteLine(jsonFromFile);


Console.WriteLine($"\n\nConverting back");
var myDataBack = JsonSerializer.Deserialize<MyData>(jsonFromFile);


Console.WriteLine($"\n\nThe result:");
Console.WriteLine($"  myData.Name        = '{myDataBack.Name       }'");
Console.WriteLine($"  myData.Description = '{myDataBack.Description}'");
Console.WriteLine($"  myData.Amount      = '{myDataBack.Amount     }'");

public class MyData
{
    public string  Name        { get; set; } = "Oliver";
    public string  Description { get; set; } = "A person on this planet";
    public decimal Amount      { get; set; } = 123.456m;
}
