using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Pronađite broj koji se sastoji od 9 znamenki u kojem se svaka znamenka od 1 do 9 pojavljuje samo jednom. Ovaj broj također mora zadovoljiti ove zahtjeve djeljivosti:

Broj bi trebao biti djeljiv sa 9.
Ako se ukloni krajnja desna znamenka, preostali broj bi trebao biti djeljiv s 8.
Ako se ukloni krajnja desna znamenka novog broja, preostali broj treba biti djeljiv sa 7.
I tako dalje, sve dok ne bude samo jedna znamenka (koja će nužno biti djeljiva s 1).
Traženi broj je: 381654729
*/

namespace kombinatorikaLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] brojevi=new int[] {1, 2, 3, 4, 5, 6, 7, 8,9};

            var odgovor = from z1 in brojevi
                          from z2 in brojevi
                          where z2 != z1 && (z1 * 10 + z2) % 2 == 0
                          from z3 in brojevi
                          where z3 != z1 && z3 != z2 && (z1 * 100 + z2 * 10 + z3) % 3 == 0
                          from z4 in brojevi
                          where z4 != z1 && z4 != z2 && z4 != z3 && (z1 * 1000 + z2 * 100 + z3 * 10 + z4) % 4 == 0
                          from z5 in brojevi
                          where z5 != z1 && z5 != z2 && z5 != z3 && z5 != z4 && (z1 * 10000 + z2 * 1000 + z3 * 100 + z4 * 10 + z5) % 5 == 0
                          from z6 in brojevi
                          where z6 != z1 && z6 != z2 && z6 != z3 && z6 != z4 && z6 != z5 && (z1 * 100000 + z2 * 10000 + z3 * 1000 + z4 * 100 + z5 * 10 + z6) % 6 == 0
                          from z7 in brojevi
                          where z7 != z1 && z7 != z2 && z7 != z3 && z7 != z4 && z7 != z5 && z7 != z6 && (z1 * 1000000 + z2 * 100000 + z3 * 10000 + z4 * 1000 + z5 * 100 + z6 * 10 + z7) % 7 == 0
                          from z8 in brojevi
                          where z8 != z1 && z8 != z2 && z8 != z3 && z8 != z4 && z8 != z5 && z8 != z6 && z8 != z7 && (z1 * 10000000 + z2 * 1000000 + z3 * 100000 + z4 * 10000 + z5 * 1000 + z6 * 100 + z7 * 10 + z8) % 8 == 0
                          from z9 in brojevi
                          where z9 != z1 && z9 != z2 && z9 != z3 && z9 != z4 && z9 != z5 && z9 != z6 && z9 != z7 && z9 != z8 && (z1 * 100000000 + z2 * 10000000 + z3 * 1000000 + z4 * 100000 + z5 * 10000 + z6 * 1000 + z7 * 100 + z8 * 10 + z9) % 9 == 0

                          let broj = z1 * 100000000 + z2 * 10000000 + z3 * 1000000 + z4 * 100000 + z5 * 10000 + z6 * 1000 + z7 * 100 + z8 * 10 + z9
                          select broj;

            Console.WriteLine("Broj je: ");

            foreach(int broj in odgovor)
            {
                Console.WriteLine(broj);
            }
            
            Console.ReadKey();
        }
    }
}
