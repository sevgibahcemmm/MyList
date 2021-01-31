using System;

namespace MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            BenimListem<string> programlamaDilleri = new BenimListem<string>();
            programlamaDilleri.Add("Pascal");// hey gidi günler hey :)
            programlamaDilleri.Add("Cobol");
            Console.WriteLine(programlamaDilleri.Count);


        }
    }
}

