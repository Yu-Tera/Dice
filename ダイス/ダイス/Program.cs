using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ダイス
{
    class Program
    {
        enum Menu { Sair, Dice}
        static void Main(string[] args)
        {
            bool option = false;
            while (!option)
            {
                Console.WriteLine("1-ダイスを振る\n0-Close");
                int op = int.Parse(Console.ReadLine());
                Menu select = (Menu)op;

                switch (select)
                {
                    case Menu.Sair:
                        option = true;
                        break;
                    case Menu.Dice:
                        Dice();
                        break;

                }
            }
        }
        static void Dice()
        {
            Console.Clear();
            Random rand = new Random();
            int roll = rand.Next(1, 7);

            Console.WriteLine("サイコロ目：" + roll);

            Face(roll);
        }

                
            
        
        static void Face(int roll)
        {
            string[] face = {
                " ―――― \n|        |\n|   ●   |\n|        |\n ―――― ",
                " ―――― \n| ●     |\n|        |\n|     ● |\n ―――― ",
                " ―――― \n| ●     |\n|   ●   |\n|     ● |\n ―――― ",
                " ―――― \n| ●  ● |\n|        |\n| ●  ● |\n ―――― ",
                " ―――― \n| ●  ● |\n|   ●   |\n| ●  ● |\n ―――― ",
                " ―――― \n| ●  ● |\n| ●  ● |\n| ●  ● |\n ―――― "
                };
            
            Console.Write(face[roll - 1]);
            Console.WriteLine("\nエンターでメニューに戻る");
            Console.ReadLine();
            Console.Clear();
        }
        
        
    }
}
            
    