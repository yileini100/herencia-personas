﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia_persona
{
    internal class Profesor :Persona
    {
        public string Asignatura { get; set; }

       
        public override void ImprimirDatos()
        {
            base.ImprimirDatos(); 
            Console.WriteLine("Asignatura: " + Asignatura);
        }
    }
}
