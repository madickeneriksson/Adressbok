﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Services
{
    class FileService
    {
        public string FilePath { get; set; } = null!;

        public void Save(string content)
        {
            using var sw = new StreamWriter(FilePath);
            sw.Write(content);
        }
        public string Read() 
        {
        try
            {
                using var sr = new StreamReader(FilePath);
                return sr.ReadToEnd();
            }
            catch { return null!; }
        }
    }
}
