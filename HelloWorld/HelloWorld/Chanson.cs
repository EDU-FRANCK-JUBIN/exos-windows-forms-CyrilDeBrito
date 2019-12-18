using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Chanson
    {
        public string nomChanson;

        public Chanson(string nomChanson)
        {
            this.nomChanson = nomChanson;
        }

        public string TitreChanson
        {
            get { return nomChanson; }
            set { TitreChanson = value; }
        }
    }
}
