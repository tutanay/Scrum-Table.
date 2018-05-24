using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrum_Table
{
  public  class Hikayee
    {
        public List<Gorev> Gorevler = new List<Gorev>();
        
        public string HBaslik;

        public string HYazar { get; set; }

        public string HAciklama { get; set; }

        public Hikayee()
        {

        }

        public void GorevYarat(Gorev gorev)
        {

            Gorevler.Add(gorev);
        }


    }
}
