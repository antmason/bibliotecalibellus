using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLlibellus
{
    class Llibre
    {
        private int isbn;

        public int Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }
        private string titolCurt;

        public string TitolCurt
        {
            get { return titolCurt; }
            set { titolCurt = value; }
        }
        private string titolLlarg;

        public string TitolLlarg
        {
            get { return titolLlarg; }
            set { titolLlarg = value; }
        }
        private int idAutor;

        public int IdAutor
        {
            get { return idAutor; }
            set { idAutor = value; }
        }
        private string resum;

        public string Resum
        {
            get { return resum; }
            set { resum = value; }
        }
        private string premis;

        public string Premis
        {
            get { return premis; }
            set { premis = value; }
        }
        private int pvp;

        public int Pvp
        {
            get { return pvp; }
            set { pvp = value; }
        }

    }
}
