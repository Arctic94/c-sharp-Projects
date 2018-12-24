using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cachipun
{
    public class Personaje
    {
        private int turnos_ganados;

        public int Turnos_ganados
        {
            get { return turnos_ganados; }
            set { turnos_ganados = value; }
        }

        public Personaje()
        {
            turnos_ganados = 0;
        }

        public int Piedra()
        {
            return 1;
        }
        public int papel()
        {
            return 2;
        }
        public int tijera()
        {
            return 3;
        }
    }
}
