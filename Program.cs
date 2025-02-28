using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab2._0
{
    class document
    {
        public string name;
        public string author;
        public string keyWords;
        public string subjectMatter;
        public string filePath;
    
        public void Inich (string name, string author, string keyWords, string subjectMatter, string filePath)
        {
            Console.WriteLine("Введите имя: ");
            name = Console.ReadLine();

            Console.WriteLine("Введите автора: ");
            author = Console.ReadLine();

            Console.WriteLine("Введите ключевые слова: ");
            keyWords = Console.ReadLine();

            Console.WriteLine("Введите тематику: ");
            subjectMatter = Console.ReadLine();

            Console.WriteLine("Введите путь к файлу: ");
            filePath = Console.ReadLine();
            
        }
        public void Print(string name, string author, string keyWords, string subjectMatter, string filePath)
        {
            Console.WriteLine("\nИмя: " + name + "\nАвтор: " + author + "\nКлючевые слова: " + keyWords + 
                "\nТематика: " + subjectMatter + "\nПуть к файлу: " + filePath);
        }
    }
    
    
        internal class Program
    {
        static void Main(string[] args)
        {
           

        }
    }
}
