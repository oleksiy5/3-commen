using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comment
{
    class City
    {
        string _name;

        public City(string name)
        {
            /*
              Przypisanie nazwy miasta 
              na zmienną _name
             */
            _name = name;
        }

        /// <summary>
        /// Pobranie nazwy miasta. Jeśli pusta to zwraca znaki ???
        /// </summary>
        /// <returns>nazwa miasta</returns>
        public string GetName()
        {
            if (string.IsNullOrEmpty(_name))
                return "???";
            else
                return _name;
        }
    }
}
