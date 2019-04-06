using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Practice_05_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise1();
            Exercise2();
        }
        static void Exercise1()
        {
            string path = @"text.txt";
            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();
            using (FileStream stream = new FileStream(path, FileMode.OpenOrCreate))
            {
                byte[] bytes = new byte[stream.Length];
                stream.Read(bytes, 0, bytes.Length);
                string data = Encoding.UTF8.GetString(bytes);
                Console.WriteLine(data);
                foreach (char symbol in data)
                {
                    if (keyValuePairs.ContainsKey(symbol))
                    {
                        keyValuePairs[symbol]++;
                    }
                    else
                    {
                        keyValuePairs.Add(symbol, 1);
                    }
                }
            }
            foreach (KeyValuePair<char, int> item in keyValuePairs)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

        }
        static void Exercise2()
        {
            string path = @"yerbol.txt";
            using (StreamWriter stream = new StreamWriter(path))
            {
                stream.WriteLine("Yerbol");
                stream.WriteLine("Irgaliyev");
                stream.WriteLine("15"); //скоро 16
            }
            Console.WriteLine("\nwrited to file!");
        }
    }
}
