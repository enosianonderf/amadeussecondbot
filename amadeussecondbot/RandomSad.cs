namespace amadeus2
{
    public class RandomSad
    {
        Random s = new Random();

        string[] SadEmos = new string[] {
            "https://raw.githubusercontent.com/enosianonderf/amadeussecondbot/master/amadeussecondbot/amadeusemo/KurisuSad/CRS_JLE_40000601.png",
            "https://raw.githubusercontent.com/enosianonderf/amadeussecondbot/master/amadeussecondbot/amadeusemo/KurisuSad/CRS_JLE_40000600.png",
            "https://raw.githubusercontent.com/enosianonderf/amadeussecondbot/master/amadeussecondbot/amadeusemo/KurisuSad/CRS_JLE_40000700.png",
        };

        public string SadRandomization()
        {
            int randomNum = s.Next(0, 2);
            string sadres = SadEmos[randomNum];
            return sadres;
        }
    }
}