
var currentDir = Directory.GetCurrentDirectory();
Console.WriteLine($"You started me in Working directory       : {currentDir}");


var filesHere = Directory.GetFiles(currentDir, "*", SearchOption.AllDirectories);
Console.WriteLine($"Files in this and all subdirectories      : ");
Console.WriteLine(string.Join('\n', filesHere));


var filesInRoot = Directory.GetDirectories(@"C:\", "*", SearchOption.TopDirectoryOnly);
Console.WriteLine($"Directories in the root dir               : {string.Join('\n', filesInRoot)}\n\n");


// get the directory for temporary files
var path1 = Path.GetTempPath();

// create a unique name that will not exist there
var path2 = Path.GetTempFileName();

// combine two paths
var completePath = Path.Combine(path1, path2);

Console.WriteLine($"Temporary filename   : {completePath}");



// Create a file
File.WriteAllText(completePath, "Hello world!");

// read file again
var contents = File.ReadAllText(completePath);
Console.WriteLine($"Contents of temporary file is  : {contents}");

// rename the file
var newFilename = completePath + ".bak";
File.Move(completePath, newFilename);

File.Delete(newFilename);
