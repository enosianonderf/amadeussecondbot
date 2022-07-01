namespace amadeus2
{
    public class RandomHappy
    {
        Random h = new Random();

        string[] HappyEmos = new string[] {
            "https://raw.githubusercontent.com/enosianonderf/amadeussecondbot/master/amadeussecondbot/amadeusemo/KurisuFun/fun4.png?token=GHSAT0AAAAAABWEESIMUBHMVK3N7GOBB2RWYV5XQ4Q",
            "https://raw.githubusercontent.com/enosianonderf/amadeussecondbot/master/amadeussecondbot/amadeusemo/KurisuFun/fun5.png?token=GHSAT0AAAAAABWEESIMUBHMVK3N7GOBB2RWYV5XQ4Q",
            "https://raw.githubusercontent.com/enosianonderf/amadeussecondbot/master/amadeussecondbot/amadeusemo/KurisuFun/fun6.png?token=GHSAT0AAAAAABWEESIM6LOKGR5GHHMVIPVWYV5XRJA",
        };

        public string HappyRandomization()
        {
            int randomNum = h.Next(0, 3);
            string hapres = HappyEmos[randomNum];
            return hapres;
        }
    }
}