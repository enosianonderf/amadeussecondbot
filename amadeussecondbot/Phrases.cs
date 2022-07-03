namespace amadeus2
{
    public class phrases
    {
        
        Random ph = new Random();
        string[] morningph = new string[]
        {
            "Доброе утро.",
            "Утро и удачного дня Вам.",
            "Вижу Вы всё еще сонный."
        };
        string[] dayph = new string[]
        {
            "Добрый день.",
            "Добрый день. Вы уже пообедали?",
            "День сегодня жаркий, не так ли?"
        };
        string[] eveph = new string[]
        {
            "Добрый вечер.",
            "Доброго вечерочка, как настроение?",
            "Фух, наконец-то прохладный вечер после жаркого дня."
        };
        string[] nightph = new string[]
        {
            "Доброй ночи.",
            "Почему Вы всё еще не спите? Вам нужно отдыхать.",
            "Довольно тихая ночь, согласны?"
        };
        public string phrandom()
        {   

            DateTime now = DateTime.Now;
            string nowtime = $"{now:HH}";
            int v = (int)Convert.ToInt64(nowtime);
            int jer = v;

            if (jer >= 0 && jer <= 6)
            {
                int randomNum = ph.Next(0, 2);
                string phres = nightph[randomNum];
                return phres;

            }

            else if (jer >= 6 && jer <= 12)
            {
                int randomNum = ph.Next(0, 2);
                string phres = morningph[randomNum];
                return phres;

            }

            else if (jer >= 12 && jer <= 18)
            {
                int randomNum = ph.Next(0, 2);
                string phres = dayph[randomNum];
                return phres;

            }

            else if (jer >= 18 && jer <= 23)
            {
                int randomNum = ph.Next(0, 2);
                string phres = eveph[randomNum];
                return phres;

            }
            else
            {
                return "";
            }

            
                
            
            
           
        }            
    }
}
