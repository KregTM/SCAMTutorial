using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

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
            
            AngryLoler myAngryLoler = new AngryLoler();
            myAngryLoler.name = "German";

            List<Enemy> enemies = new List<Enemy>();
            enemies.Add(myAngryDoter);
            enemies.Add(myAngryLoler);

            for (int i = 0; i < enemies.Count; i++)
            {
                enemies[i].Move();
            }

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
            base.Move();
            Console.WriteLine("Angry Doter move");
        }
    }

    class AngryLoler : Enemy
    {
        override public void Move()
        {
            base.Move();
            Console.WriteLine("Angry Loler move");
        }
    }
}
