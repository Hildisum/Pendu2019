using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pendu2019
{
    class Program
    {

        static bool EstUneLettre(char a)
        {
            bool MyBool = false;
            if ((a >= 'a') && (a <= 'z'))
            {
                MyBool = true;
                Console.WriteLine("Ce caractère est bien une lettre.");
                return MyBool;
            }

            if ((a >= 'A') && (a <= 'Z'))
            {
                MyBool = true;
                Console.WriteLine("Ce caractère est bien une lettre.");
                return MyBool;
            }

            else
            {
                Console.WriteLine("Ce caractère est invalide.");
                return MyBool;
            }
        }
        static char LettreEnMajuscule(char a)
        {
            if (a )
        }
        static void Main(string[] args)
        {
            char MaLettre = 'D';
            EstUneLettre(MaLettre);
        }
    }
}
