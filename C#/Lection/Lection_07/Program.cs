string path = "/Users/Intel/Downloads/Geek/Курс - Знакомство со специализацией/introduction_to_programming_languages/C#/Lection/Lection_07/";
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();

for (int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);
}