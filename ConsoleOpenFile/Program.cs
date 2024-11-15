using System;
using System.IO;

namespace ConsoleOpenFile{
    class Program {
        public static void Main() {
            FileStream fs = null;
            try
            {
                fs = new FileStream(@"D:\Projetos\C#\ConsoleOpenFile\ConsoleOpenFile\data.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                while (!sr.EndOfStream) {
                        Console.WriteLine(sr.ReadLine());
                    }                      
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close(); 
                    fs.Dispose();
                }
            }        
        }
    }
}


