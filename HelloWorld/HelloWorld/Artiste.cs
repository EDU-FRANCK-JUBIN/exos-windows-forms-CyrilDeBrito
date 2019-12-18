using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Artiste
    {
        public string nomArtiste;

        public Artiste(string nomArtiste)
        {
            this.nomArtiste = nomArtiste;
            List<Chanson> listChansons = new List<Chanson>();
        }

        
    }
}
