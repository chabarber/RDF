using System;
using System.IO;

namespace RDF
{
    public class Program
    {
        public static void Main(string[] args)
        {

        }

       

       
        public static void CheckFileExists(string filename)
        {
            if(!System.IO.File.Exists(filename))
            {
                Console.WriteLine("File does not exist");
                //return true;       
            }
        }
        
    }

    
}
