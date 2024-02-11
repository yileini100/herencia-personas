using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia_persona
{
    internal class Estudiante:Persona
    {
        public string Carrera { get; set; }

        public override void ImprimirDatos()
        {
            base.ImprimirDatos(); 
            Console.WriteLine("Carrera: " + Carrera);
        }
    }
}
