using Telegram.Bot;
using Telegram.Bot.Args;

namespace amadeus2
{
    class ASB
// Токен и определение самого бота
    {
        public static int emo = 50;
        private static string token { get; set; } = "2008109914:AAFi-o9eFEgMaLO8k22F9Tmq4BmzwiROkLI";
        private static TelegramBotClient bot;
        static void Main(string[] args)
        {
            RandomAngry a = new RandomAngry();
            RandomHappy h = new RandomHappy();
            Console.WriteLine("Запуск бота...");
            
            bot = new TelegramBotClient(token);
            bot.OnMessage += BotOnOnMessage;
            bot.StartReceiving();
            Console.ReadLine();
            
        }
        private static async void BotOnOnMessage(object? sender, MessageEventArgs e)
        {
            
            RandomAngry a = new RandomAngry();
            RandomHappy h = new RandomHappy();
            var msg = e.Message;
            var lower = msg.Text.ToLower();
            if (msg.Text != null)
            {
                Console.WriteLine($"Введено : {msg.Text}");
                if(lower.Contains("кристин"))
                {
                    await bot.SendTextMessageAsync(msg.Chat.Id, "Не называй меня Кристиной!");
                }              
                if (lower.Contains("привет"))
                {
                    await bot.SendPhotoAsync(
                    chatId: msg.Chat.Id,
                    parseMode: Telegram.Bot.Types.Enums.ParseMode.Html,
                    photo: a.AngryRandomization(),
                    caption: "Здравствуйте.");
                }
                if (lower.Contains("дура"))
                {
                    emo = emo - 20;
                    await bot.SendPhotoAsync(
                    chatId: msg.Chat.Id,
                    photo: "https://github.com/enosianonderf/amadeussecondbot/blob/master/amadeussecondbot/amadeusemo/KurisuAngry/CRS_JLE_40000400.png?raw=true",
                    caption: "Сам дурак!");
                }
                if (lower.Contains("смеш"))
                {
                    emo = emo + 20;
                    await bot.SendPhotoAsync(
                    chatId: msg.Chat.Id,
                    photo: h.HappyRandomization(),
                    caption: "Хаха!");
                }
            }        
        }      
    }
}