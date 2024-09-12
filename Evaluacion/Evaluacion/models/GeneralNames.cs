using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion.models
{
    internal class GeneralNames
    {
        private string[] names = new string[25]; // Creacion del arreglo
        public void AddNames(string name, int pos)
        {
            names[pos] = name; // Las edades en la posicion que se le indique
        }
        public string[] GetNames() 
        { 
            return names; // Devuelve el arreglo 
        }
    }
}
