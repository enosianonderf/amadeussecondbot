namespace amadeus2
{
    public class RandomEmb
    {
        Random emb = new Random();

        string[] EmbEmos = new string[] {
            "https://raw.githubusercontent.com/enosianonderf/amadeussecondbot/master/amadeussecondbot/amadeusemo/KurisuEmb/CRS_JLE_40000200.png",
            "https://raw.githubusercontent.com/enosianonderf/amadeussecondbot/master/amadeussecondbot/amadeusemo/KurisuEmb/CRS_JLE_40000201.png",
            "https://raw.githubusercontent.com/enosianonderf/amadeussecondbot/master/amadeussecondbot/amadeusemo/KurisuEmb/emb1.png",
        };

        public string EmbRandomization()
        {
            int randomNum = emb.Next(0, 3);
            string embres = EmbEmos[randomNum];
            return embres;
        }
    }
}