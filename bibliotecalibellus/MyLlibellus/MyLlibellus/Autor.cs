using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLlibellus
{
    class Autor
    {
        private int idAutor;
        private string nom;
        private string cognoms;

        public int IdAutor
        {
            get { return idAutor; }
            set { idAutor = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Cognoms
        {
            get { return cognoms; }
            set { cognoms = value; }
        }
    }
}
