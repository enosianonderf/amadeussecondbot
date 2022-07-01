namespace amadeus2 {
    public class RandomAngry
    {
        Random a = new Random();

        string[] AngryEmos = new string[] { "https://raw.githubusercontent.com/enosianonderf/amadeussecondbot/master/amadeussecondbot/amadeusemo/KurisuAngry/CRS_JLE_40000400.png?token=GHSAT0AAAAAABWE5JECCFRN43VC55PTMZUMYV5XEWA",
            "https://raw.githubusercontent.com/enosianonderf/amadeussecondbot/master/amadeussecondbot/amadeusemo/KurisuAngry/CRS_JLE_40000401.png?token=GHSAT0AAAAAABWE5JEDQ4Y57MEURTF4HPGAYV5XEEA",
            "https://raw.githubusercontent.com/enosianonderf/amadeussecondbot/master/amadeussecondbot/amadeusemo/KurisuAngry/CRS_JLE_40000402.png?token=GHSAT0AAAAAABWE5JEDGBV4BGURGLLCZSSGYV5XDZQ"
        };

        public string AngryRandomization()
        {
            int randomNum = a.Next(0, 3);
            string str = AngryEmos[randomNum];
            return str;
        }
    }
    
}