using System;
using System.IO;

class Program
{
    static string currentDirectory = "C:\\Users\\USER"; // Boshlang'ich papka

    static void Main()
    {
        string command;

        do
        {
            Console.Write($"{currentDirectory}> ");
            command = Console.ReadLine();

            string[] parts = command.Split(' ');

            if (parts.Length > 0)
            {
                string cmd = parts[0].ToLower();

                if(command == "cd ..")
                {
                    cmd = "cd ..";
                }
                
                switch (cmd)
                {
                    case "cd":
                        DirectoriyagaKirish(parts);
                        break;
                    case "cd ..":
                        BirQadamOrqaga();
                        break;
                    case "dir":
                        Directoriyalar();
                        break;
                    case "mkdir":
                        DirectoriyaYaratish(parts);
                        break;
                    case "md":
                        DirectoriyaYaratish(parts);
                        break;
                    case "exit":
                        break;
                    default:
                        Console.WriteLine("Noma'lum komanda");
                        break;
                }
            }

        } while (!command.ToLower().Equals("exit"));
    }

    private static void DirectoriyaYaratish(string[] parts)
    {
        string path =  currentDirectory + "\\" +  parts[1];
        Directory.CreateDirectory(path);
    }

    private static void Directoriyalar()
    {
        string[] directorys = Directory.GetDirectories(currentDirectory);

        foreach (string directory in directorys)
        {
            Console.WriteLine(directory.Replace(currentDirectory, ""));
        }
    }

    private static void BirQadamOrqaga()
    {
        string[] parts = currentDirectory.Split('\\');

        currentDirectory = currentDirectory.Replace("\\" + parts[parts.Length  - 1], "");

    }

    private static void DirectoriyagaKirish(string[] parts)
    {
        currentDirectory += "\\" + parts[1];   
    }
}
