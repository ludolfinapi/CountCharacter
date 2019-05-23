using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a word");
            string Myword = Console.ReadLine();
            
            int[] countChar = new int[26];

            for (int i= 0;  i < Myword.Length; i++)
                countChar[Myword[i] - 97]++;//a-97 daje 0 , b-97 daje 1 itd mam wyzerowana tablice
            //zwiekszam wartos elenementu gdy litera pojawi sie kolejny raz

            for(int i=0; i<26; i++)
            {
                if (countChar[i] != 0)
                     
                    Console.WriteLine("Character {0} are {1}", (char)(i+97), countChar[i] );
                //(char)(i+97) konwertuje int na litere
            }

            Console.ReadKey();

        }
    }
}
