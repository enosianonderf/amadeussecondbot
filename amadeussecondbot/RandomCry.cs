namespace amadeus2
{
    public class RandomCry
    {
        Random c = new Random();

        string[] CryEmos = new string[] { "https://raw.githubusercontent.com/enosianonderf/amadeussecondbot/master/amadeussecondbot/amadeusemo/KurisuCry/cry1.png",
            "https://raw.githubusercontent.com/enosianonderf/amadeussecondbot/master/amadeussecondbot/amadeusemo/KurisuCry/cry3.png",
            "https://raw.githubusercontent.com/enosianonderf/amadeussecondbot/master/amadeussecondbot/amadeusemo/KurisuCry/cry2.png"
        };

        public string CryRandomization()
        {
            int randomNum = c.Next(0, 3);
            string cryres = CryEmos[randomNum];
            return cryres;
        }
    }
}