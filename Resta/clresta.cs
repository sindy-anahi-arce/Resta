using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resta
{
    class clresta
    {
        //Atributos
        private int num1;
        private int num2;

        //Constructor(Es el que dirige)
        public clresta(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        //Método
        public int resta()
        {
            return (num1 - num2);
        }
    }
}
