using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvjeraZaIspit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Napišite program koji će deklarirati dva niza tipa int veličine 10 članova, te će zatražiti od korisnika da unosi brojeve. 
             * Ako korisnik unese neparni broj spremite ga u prvi niz, a ako unese parni spremite ga u drugi niz. 
             * Program treba prestati s radom ako korisnik unese 0 ili kad ukupan broj članova dodijeljenih pojedinom nizu premaši 10. 
             * Na kraju ispišite sve članove nizova.*/

            Console.WriteLine("----- ZADATAK 1 -----");
            int[] parni = new int[10];
            int[] neparni = new int[10];
            int priv;
            int clanovi1 = 0;
            int clanovi2 = 0;
            int i = 0;
            do
            {
                Console.WriteLine("Unesi broj: ");
                {
                    priv = Convert.ToInt32(Console.ReadLine());
                    if(priv == 0)
                    {
                        break;
                    }
                    else if(priv % 2 == 0)
                    {
                        neparni[clanovi1] = priv;
                        clanovi1++;
                    }
                    else if(priv % 2 != 0)
                    {
                        parni[clanovi2] = priv;
                        clanovi2++;
                    }
                }
            } while (clanovi1 < 10 && clanovi2 < 10);

            Console.Write("Parni brojevi: ");
            for (i = 0; i < clanovi1; i++)
            {
                Console.Write(parni[i] + ", ");
            }
            Console.Write("\nNeparni brojevi: ");
            for (i = 0; i < clanovi2; i++) 
            {
                Console.Write(neparni[i] + ", ");
            }
            


            /*Napišite program koji će definirati 2 niza tipa int, 
             * te će izračunati broj članova koji se nalaze na istom indeksu i imaju istu vrijednost. 
             * Program mora raditi ispravno za proizvoljni broj članova niza.*/
            Console.WriteLine("\n----- ZADATAK 2 -----");

            int privremena;
            Console.WriteLine("Unesi broj članova niza: ");
            privremena = Convert.ToInt32(Console.ReadLine());
            int[] niz1 = new int[privremena];
            int[] niz2 = new int[privremena];
            int isti = 0;
            for(i = 0; i < privremena; i++)
            {
                Console.WriteLine("Unesi " + (i + 1) + ". član prvog niza: ");
                niz1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < privremena; i++)
            {
                Console.WriteLine("Unesi " + (i + 1) + ". član drugog niza: ");
                niz2[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(i = 0; i < privremena; i++)
            {
                if (niz1[i] == niz2[i])
                {
                    isti++;
                }
            }
            Console.WriteLine("Broj članova koji se nalaze na istom indeksu i imaju istu vrijednost je: " + isti);
            Console.ReadKey();

        }
    }
}
