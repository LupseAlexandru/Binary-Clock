using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Clock
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Introduceti ora curenta (format: Ore:Minute:Secunde):");
            string oracurentainput = Console.ReadLine();

            if (ValidareOraCurenta(oracurentainput))
            {
                ConversieBinar(oracurentainput);
            }
            else
            {
                Console.WriteLine("Formatul orei nu este introdus corect.");
            }
        }

        static bool ValidareOraCurenta(string oracurentainput)
        {
            return DateTime.TryParse(oracurentainput, out _);
        }

        static void ConversieBinar(string oracurentainput)
        {
            DateTime oracurenta = DateTime.Parse(oracurentainput);

            int ore = oracurenta.Hour;
            int minute = oracurenta.Minute;
            int secunde = oracurenta.Second;

            Console.WriteLine($"Ora binara: {Convert.ToString(ore, 2).PadLeft(5, '0')}:{Convert.ToString(minute, 2).PadLeft(6, '0')}:{Convert.ToString(secunde, 2).PadLeft(6, '0')}");
        }
    }


}
