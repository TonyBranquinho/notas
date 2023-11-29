using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notas {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            double primeira, segunda, final;

            Console.Write("Digite a primeira nota: ");
            primeira = double.Parse(Console.ReadLine(), CI);
            Console.Write("Digite a segunda nota: ");
            segunda = double.Parse(Console.ReadLine(), CI);

            final = primeira + segunda;

            Console.WriteLine("NOTA FINAL = "+final.ToString("F1", CI));

            if (final < 60.0) {
                Console.WriteLine("REPROVADO.");
            }

        }
    }
}
