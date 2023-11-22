using ConsoleApp9;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace ConsoleApp9
{
    class program
    {
        static void Main(string[] args)
        {
            const string dobogatas = "dobasok.txt";
            const string osvenykedes = "osvenyek.txt";
            List<string> dobigatasLista = new List<string>();
            List<string> osvenykedesLista = new List<string>();

            
            void Dobas()
            {
                StreamReader sr = new StreamReader(dobogatas);
                while (!sr.EndOfStream)
                {
                    string[] dob = sr.ReadLine().Split(" ");
                    for (int i = 0; i < dob.Length; i++)
                    {
                        dobigatasLista.Add(dob[i]);
                    }
                }
                sr.Close();
            }
            
            void Osveny()
            {
                StreamReader sr = new StreamReader(osvenykedes);
                while (!sr.EndOfStream)
                {
                    
                    osvenykedesLista.Add(sr.ReadLine());
                }
                sr.Close();

            }

            void masodik()
            {
                Console.WriteLine("2.feladat");
                Console.WriteLine($"A dobások száma: {dobigatasLista.Count()}");
                Console.WriteLine($"Az ösvények száma: {osvenykedesLista.Count()}");
            }
            /*
            void harmadik()
            {
                int hanyadik = 0;
                int hossza = 0;
                 


            }
            */
            void otodik()
            {
                int Mosveny = 0;
                int Vosveny = 0;
                int Eosveny = 0;
                foreach (var item in osvenykedesLista)
                {

                    if (item == "M")
                    {
                        Mosveny++;
                    }
                    else if (item == "V") 
                    {
                        Vosveny++;
                    }
                    else
                    {
                        Eosveny++;
                    }
                }
                Console.WriteLine($"5.feladat\nM: {Mosveny} darab \nV: {Vosveny} darab \nE: {Eosveny} darab");
            }

            Dobas();
            Osveny();
            masodik();
            otodik();
        }

    }
}