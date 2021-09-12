using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROMA400MMR
{
    class Program
    {
        static void Main(string[] args)
        {   /*
            String mString = "Name";
            Enemy myEnemy = new Enemy();
            

            myEnemy.Attack();
            myEnemy.Move();
            */
            AngryDoter myAngryDoter = new AngryDoter();
            myAngryDoter.name = "Arseniy";
            myAngryDoter.Attack();
            myAngryDoter.Move();
            

            Console.WriteLine("Doter name: " + myAngryDoter.name);
            Console.ReadLine();
        }
    }


    class Enemy
        {
        public int damage;
        public String name;

        /*public Enemy(int enemyDamage, String enemyName)
        {
            damage = enemyDamage;
            name = enemyName;                                          
        }*/

        public void Attack()
        {
            Console.WriteLine("Baza kormit detey svoih");
        }

        virtual public void Move()
        {
            Console.WriteLine("Baza dvishet detey svoih");
        }
       
    }
    
    class AngryDoter : Enemy
    {
        public override void Move()
        {
            Console.Write("Angry Doter move");
        }
    }
}
