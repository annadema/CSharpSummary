using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace stringDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Formatting
            var str1 = "    CIAOAnnamaria    ";
            var str2= str1.ToLower();
            Console.WriteLine(str2);
            var str3 = str1.ToUpper();
            Console.WriteLine(str3);
            var str4 = str1.Trim();
            Console.WriteLine(str4);

            //Searching
            var index = str1.IndexOf("A");
            Console.WriteLine(index);
            var index1 = str1.IndexOf("Anna");
            Console.WriteLine(index1);
            var index2 = str1.LastIndexOf("a");
            Console.WriteLine(index2);

            //substring
            var str5 = str1.Substring(index1, 4);
            Console.WriteLine(str5);
            
            //replace
            var str6 = str1.Replace("CIAO", "");
            var str7 = str6.Trim();
            Console.WriteLine(str7);
            var str8 = str7.Replace("maria", " Maria");
            Console.WriteLine(str8);

            //null checking
            Console.WriteLine(String.IsNullOrEmpty(" "));  //false
            Console.WriteLine(String.IsNullOrWhiteSpace(" ")); //true

            //splitting
            Console.WriteLine("\t\t\t\tSPLITTING");
            string frase = "Ciao Mistral tu sei il gatto più bello del mondo!";
            var words = frase.Split(' ');
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }

            //Converting strings to numbers
            string s = "1234";
            int j = Convert.ToInt32(s);
            Console.WriteLine(j);
            try
            {
                int i = int.Parse("");
                Console.WriteLine(i);
            }
            catch 
            {
                Console.WriteLine("Parse genera eccezione se la stringa è vuota");
            }
            try
            {
                Console.WriteLine(Convert.ToInt32(""));

            }
            catch 
            {
                Console.WriteLine("Anche Convert genera eccezione se la stringa è vuota");
            }
            

            //converting numbers  to string
            int k = 1234;
            Console.WriteLine("int convertito in stringa: "+ k.ToString("E2"));
            Console.WriteLine("int convertito in stringa: " + k.ToString("C"));
            Console.WriteLine("int convertito in stringa: " + k.ToString("C0"));
            Console.WriteLine("int convertito in stringa: " + k.ToString("X"));



        }
    }
}
