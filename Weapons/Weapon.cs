using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapons
{
    class Weapon
    {
        private string name;
        private float caliber;
        private double range;

        public string Name { get; set; }
        public float Caliber { get; set; }
        public double Range { get; set; }

        public Weapon()
        {
            Name = null;
            Caliber = 0;
            Range = 0;
        }

        public void Input()
        {
            Console.WriteLine("Введите хар-ку оружия");
            Console.WriteLine("Введите название: ");
            Name = Console.ReadLine();
            Console.WriteLine("Введите калибр: ");
            Caliber = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите дальность: ");
            Range = Convert.ToDouble(Console.ReadLine());
        }
        public void Print()
        {
            Console.WriteLine("Хар-ка оружия");
            Console.WriteLine("Название " + Name);
            Console.WriteLine("Калибр " + Caliber);
            Console.WriteLine("Дальность " + Range);
        }
    }
}
