// FILE I/O DEMO by Mr. V
// Place all code into main()

// Read Entire Contents of File as a Single String
// File.ReadAllText(path_to_file);
string contents = File.ReadAllText(@"F:\__CS\C#\file-io-demo\data.txt");
Console.WriteLine(contents);

// Read Entire Contents of File into an Array
// Each array element is a line from the file
// File.ReadAllLines(path_to_file);
string[] lines = File.ReadAllLines(@"F:\__CS\C#\file-io-demo\data.txt");
Console.WriteLine(string.Join(",", lines));

// Write String Data to File
// File will be created if it doesn't exist
// File.WriteAllText(path_to_file, string_to_write);
string myData = "Hello Files!!\nThis is a new line.";
File.WriteAllText(@"F:\__CS\C#\file-io-demo\data2.txt", myData);
