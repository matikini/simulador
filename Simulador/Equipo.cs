using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simulador
{
    class Equipo
    {
        public string nombre { get; set; }
        public string fuerza { get; set; }
        public List<Jugador> Jugadores = new List <Jugador>();
    }
}
