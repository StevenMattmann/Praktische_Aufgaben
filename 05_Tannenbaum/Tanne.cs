using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Tannenbaum
{
    public class Tanne
    {
        public int Stammhoehe { get; set; }
        public int Stammbreite { get; set; }
        public int Kronenhoehe { get; set; }

        public Tanne(int stammhoehe, int stammbreite, int kronenhoehe)
        {
            Stammhoehe = stammhoehe;
            Stammbreite = stammbreite;
            Kronenhoehe = kronenhoehe;
        }
        public string Zeichnen()
        {
            StringBuilder TannenZeichnen = new StringBuilder();

            for (int i = 1; i <= Kronenhoehe; i++)
            {
                TannenZeichnen.AppendLine(new string(' ', Kronenhoehe - i) + new string('*', 2 * i - 1));
            }

            for (int i = 0; i < Stammhoehe; i++)
            {
                TannenZeichnen.AppendLine(new string(' ', (Kronenhoehe - 1) - (Stammbreite / 2)) + new string('*', Stammbreite));
            }

            return TannenZeichnen.ToString();
        }
    }
}
