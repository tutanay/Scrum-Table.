using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrum_Table
{
    public class Baglanti
    {
        public List<Hikayee> Hikayeler = new List<Hikayee>();


        public void HikayeYarat(Hikayee hikaye)
        {
            Hikayeler.Add(hikaye);
        }
    }
}
