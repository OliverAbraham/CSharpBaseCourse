
Console.WriteLine($"DONT USE THESE !!!");
Console.WriteLine($"My home drive variable                 	  : {Environment.GetEnvironmentVariable("HOMEDRIVE")}");
Console.WriteLine($"My home path variable                     : {Environment.GetEnvironmentVariable("HOMEPATH")}");
Console.WriteLine($"My home drive variable                 	  : {Environment.GetEnvironmentVariable("HOMEDRIVE")}");
Console.WriteLine($"The folder for temporary files is         : {Environment.GetEnvironmentVariable("TEMP")}");


Console.WriteLine($"\n\n\nUSE THESE !!!");
Console.WriteLine($"You started me in Working directory       : {Directory.GetCurrentDirectory()}");
Console.WriteLine($"The folder for temporary files is         : {Path.GetTempPath()}");
Console.WriteLine($"My personal folders                       : {Environment.GetFolderPath(Environment.SpecialFolder.MyComputer)}");
Console.WriteLine($"My personal folders                       : {Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}");
Console.WriteLine($"My personal folders                       : {Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)}");
Console.WriteLine($"My personal folders                       : {Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)}");
Console.WriteLine($"My personal folders                       : {Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)}");
Console.WriteLine($"My personal folders                       : {Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86)}");

// check out the "set" command on the commandline!

