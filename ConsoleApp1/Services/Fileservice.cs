﻿
namespace ConsoleApp1.Services
{
    public class Fileservice
    {
        public void Save(string filePath, string content)
        { 
            using var sw = new StreamWriter(filePath);
            sw.WriteLine(content);
        }
        public string Read(string filePath)
        {
            try
            {
                using var sr = new StreamReader(filePath);
                return sr.ReadToEnd();
            }
            catch 
            {
                return null!; 
            }
        }
    }
}
