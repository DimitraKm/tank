using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace tank
{
    internal class tank
    {
        public string name;
        public int ammo;
        public string type;
        public int year;


        public tank(int ammo, string type, int year)
        {
            this.ammo = ammo;
            this.type = type;
            this.year = year;

            Console.Write("Enter your Pokemon's name: ");
            string name1 = Console.ReadLine();
            Console.Write("Enter your Pokemon's name: ");
            string name2 = Console.ReadLine();

            Console.WriteLine(name1 + "'s turn");
            int enemyAttack = int.Parse(Console.ReadLine());
            if (enemyAttack <= 5)
            {
                Console.WriteLine(name2 + " lost health: " + enemyAttack * 10);

                Console.WriteLine(name2 + "'s turn");

                int enr = int.Parse(Console.ReadLine());
                if (enr <= 5)
                {

                    Console.WriteLine(name1 + " Lost health " + enr * 10);
                    Console.WriteLine(name1 + "'s turn");
                    
                    int damag = int.Parse(Console.ReadLine());
                    if (damag == 3)
                    {
                        Console.WriteLine(name2 + " Lost health " + enr * 10);
                        Console.WriteLine(name2 + "'s turn");

                        int d = int.Parse(Console.ReadLine());
                        if (d == 3)
                        {
                            Console.WriteLine(name1 + " Lost health " + enr * 10);
                            Console.WriteLine(name1 + "'s turn");
                        }
                        else
                        {
                            Console.WriteLine("Critical hit!! " + name1 + " fainted");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Critical hit!! " + name2 + " fainted");
                    }
                }
                else
                {
                    Console.WriteLine("Critical hit!! " + name1 + " fainted");
                }
            }
            else
            {
                Console.WriteLine("Critical hit!! " + name2 + " fainted");
            }
        }
    }
}
