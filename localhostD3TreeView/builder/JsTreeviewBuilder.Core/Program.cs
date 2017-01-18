using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsTreeviewBuilder.Core
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Starting ...");

                var outputHtmlFile = @"c:/path/to/your/file.htm";
                var builder = new Builder(outputHtmlFile);
                builder.Process();

                Console.WriteLine("Done.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Console.WriteLine("Press any key to finish ...");
            Console.ReadKey();
        }
    }
}
