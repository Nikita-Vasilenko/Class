using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Chicla
    {
        private double materialone;
        private double materialtwo;
        public Chicla(double materialone, double materialtwo)
        {
            this.materialone = materialone;
            this.materialtwo = materialtwo;
        }
        private double Sum()
        {
            return materialone * materialone + materialtwo * materialtwo;
        }

        public void Print()
        {
            Console.WriteLine("Число а:"+ materialone+"Число b:"+ materialtwo+"Сумма:"+Sum());
        }
    }
}
