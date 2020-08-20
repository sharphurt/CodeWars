using System;
using System.Collections.Generic;
using System.Linq;

namespace FindFileInFolder
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var myFolder = new Folder("All",
                new List<Item>
                {
                    new File("readme"),
                    new File("question"),
                    new Folder("Docs",
                        new List<Item>
                        {
                            new File("info"),
                            new File("answer")
                        })
                });

            Console.WriteLine(Search.FindFileInFolder(myFolder, "answer"));
        }
    }

    public class Search
    {
        public static string FindFileInFolder(Folder folder, String fileName)
        {
            var innerFiles = folder.Items;
            if (innerFiles.Exists(i => i.Name == fileName))
                return $"{folder.Name}\\{fileName}";
            foreach (var innerResult in innerFiles.FindAll(i => i is Folder).Cast<Folder>()
                .Select(dir => FindFileInFolder(dir, fileName)).Where(innerResult => innerResult != ""))
                return $"{folder.Name}\\{innerResult}";
            return "";
        }
    }

    public abstract class Item
    {
        public string Name { get; set; }
    }

    public class File : Item
    {
        public File(string name)
        {
            Name = name;
        }
    }

    public class Folder : Item
    {
        public Folder(string name, List<Item> items)
        {
            Name = name;
            Items = items;
        }

        public List<Item> Items { get; set; }
    }
}