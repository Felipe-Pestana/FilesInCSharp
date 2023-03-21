using System.Text;
string filename = "texto.txt";
string path = @"C:\\Users\\" + System.Environment.UserName + "\\";
//Console.Write(path);

using (var file = new StreamWriter(path + filename))
{
    var text = new StringBuilder();
    file.Write(text);

    Console.WriteLine($"\nArquivo salvo em " + path + filename);
    Console.ReadKey();
}

using (var file = new StreamReader(path + filename))
{
    Console.Clear();
    
    var text = file.ReadToEnd();

    Console.WriteLine(text);
    Console.ReadKey();
}