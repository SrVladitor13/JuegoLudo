using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDeLudo
{
    static class Dado
    {
        public static Random rnd = new Random();


        public static int tirar()
        {
            return (rnd.Next(1, 7));
        } 
    }
}
