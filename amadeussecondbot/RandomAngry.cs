using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amadeus2 {
    public class RandomAngry
    {

        string[] AngryEmos = new string[] { "https://github.com/enosianonderf/amadeussecondbot/blob/master/amadeussecondbot/amadeusemo/KurisuAngry/CRS_JLE_40000400.png?raw=true",
            "https://github.com/enosianonderf/amadeussecondbot/blob/master/amadeussecondbot/amadeusemo/KurisuAngry/CRS_JLE_40000401.png?raw=true",
            "https://github.com/enosianonderf/amadeussecondbot/blob/master/amadeussecondbot/amadeusemo/KurisuAngry/CRS_JLE_40000402.png?raw=true%22%7D"
        };

    public string Randomization()
        {
            string str = AngryEmos[new Random().Next(0, AngryEmos.Length)];
            return str;
        }

    }
}