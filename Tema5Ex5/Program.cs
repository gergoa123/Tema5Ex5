using System;

namespace Tema5Ex5
{
    //Ex 5
    //Un program care va normaliza un sir de caractere citit de la tastatura astfel incat fiecare cuvant din
    //sir sa inceapa cu MAJUSCULA, restul literelor fiind transformate in litere mici
    

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Introduceti string-ul!");
            string sir = Console.ReadLine();
            string lowercase = sir.ToLower();

            string[] split = lowercase.Split(' ',  StringSplitOptions.RemoveEmptyEntries);

            //foreach (string fragment in split)
            //{
            //    fragment = (Char.ToUpper(fragment[0]) + fragment.Substring(1));
            //}
            //

            for (int i = 0; i < split.Length; ++i)
            {
                split[i] = (Char.ToUpper(split[i][0]) + split[i].Substring(1));
            }


            foreach (string fragment in split)
            {
                Console.Write(fragment + " ");
            }
        }
    }
}
