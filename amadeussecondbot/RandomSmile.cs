namespace amadeus2 {
    public class RandomSmile
    {
        Random sm = new Random();

        string[] SmileEmos = new string[] { "https://raw.githubusercontent.com/enosianonderf/amadeussecondbot/master/amadeussecondbot/amadeusemo/KurisuSmile/CRS_JLE_40000300.png",
            "https://raw.githubusercontent.com/enosianonderf/amadeussecondbot/master/amadeussecondbot/amadeusemo/KurisuSmile/CRS_JLE_40000301.png",
            "https://raw.githubusercontent.com/enosianonderf/amadeussecondbot/master/amadeussecondbot/amadeusemo/KurisuSmile/CRS_JLE_40000302.png"
        };

        public string SmileRandomization()
        {
            int randomNum = sm.Next(0, 3);
            string str = SmileEmos[randomNum];
            return str;
        }
    }
    
}