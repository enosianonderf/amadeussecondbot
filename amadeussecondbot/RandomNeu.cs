namespace amadeus2
{
    public class RandomNeu
    {
        Random n = new Random();

        string[] NeuEmos = new string[] {
            "https://raw.githubusercontent.com/enosianonderf/amadeussecondbot/master/amadeussecondbot/amadeusemo/KurisuNeutral/CRS_JLD_40000901.png",
            "https://raw.githubusercontent.com/enosianonderf/amadeussecondbot/master/amadeussecondbot/amadeusemo/KurisuNeutral/neu1.png",
            "https://raw.githubusercontent.com/enosianonderf/amadeussecondbot/master/amadeussecondbot/amadeusemo/KurisuNeutral/neu2.png",
        };

        public string NeuRandomization()
        {
            int randomNum = n.Next(0, 3);
            string neures = NeuEmos[randomNum];
            return neures;
        }
    }
}