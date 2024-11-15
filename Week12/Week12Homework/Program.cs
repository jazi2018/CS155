using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week12Homework;
namespace Homework10
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialize pack
            AlienPack pack = new AlienPack(3);

            //create aliens
            OgreAlien grimblo = new OgreAlien(100, "Grimblo");
            SnakeAlien snazlo = new SnakeAlien(100, "Snazlo");
            MarshmallowManAlien blorb = new MarshmallowManAlien(100, "Blorb");

            //add to alien pack
            pack.AddAlien(grimblo, 0);
            pack.AddAlien(snazlo, 1);
            pack.AddAlien(blorb, 2);

            //calculate damage. we should expect 17 damage (6 + 10 + 1)
            int damage = pack.CalculateDamage();

            Console.WriteLine("The alien pack will do {0} damage.", damage);
        }
    }
}