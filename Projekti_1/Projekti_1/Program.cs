using System.Globalization;

namespace Projekti_1
{

    public class ArrayMin
    {

        public void Min(int madhesia)
        {

            int meIVogli = 1000000;

            int[] Lista = new int[100];

            for (int i = 0; i < madhesia; i++)
            {
                Console.WriteLine("Elementi {0}: ", i+1);
                Lista[i] = Convert.ToInt32(Console.ReadLine());
            }

            for( int j = 0; j < madhesia; j++)
            {
                if (Lista[j] < meIVogli)
                {
                    meIVogli = Lista[j];
                }
            }

            Console.WriteLine("Numri me i vogel qe keni shkruar eshte: " + meIVogli);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Sa elemente doni qe te kete lista juaj ?");
            int madhesia = Convert.ToInt32(Console.ReadLine());

            ArrayMin arraymin = new ArrayMin();

            arraymin.Min(madhesia);
        }
    }
}