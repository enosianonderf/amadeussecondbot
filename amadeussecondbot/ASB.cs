using Telegram.Bot;
using Telegram.Bot.Args;
using System.Net;

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
            
           

            DateTime now = DateTime.Now;
            Console.WriteLine("Запуск бота...");
            Console.WriteLine($"Инициализация бота {now:T}");
            WebClient Client = new WebClient();
            String Response;
            try
            {   
                Response = Client.DownloadString("http://test.vkgroup.az/");
                if (Response != null)
                {   

                    Console.WriteLine("Запуск успешен! Бот находится в исправно-активном состоянии.");
                    Console.WriteLine($"Бот запущен {now:R}");
                }

            }
            catch
            {
                Console.WriteLine("Запуск бота провален.");
                Console.WriteLine($"Бот не работает. Попробуйте подключиться позже. {now:R}");
            }
            

            bot = new TelegramBotClient(token);
            bot.OnMessage += BotOnOnMessage;
            bot.StartReceiving();
            Console.ReadLine();
            
        }



        private static async void BotOnOnMessage(object? sender, MessageEventArgs e)
        {
            using var stream = new MemoryStream();
            RandomAngry a = new();
            RandomHappy h = new();
            RandomSad s = new();
            RandomCry c = new();
            RandomNeu n = new();
            var msg = e.Message;
            var lower = msg.Text.ToLower();


            if (msg.Text != null)
            {
                /*if (emo <= 20)
                {
                    string emostatus = a.AngryRandomization();
                }
                else if (emo >= 85 && emo <= 100)
                {
                    string emostatus = h.HappyRandomization();
                }
                */
                Console.WriteLine($"Введено : {msg.Text}");
                if (lower.Contains("ты") && lower.Contains("бот"))
                {
                    stream.Position = 0;
                    emo = 30;
                    await bot.SendPhotoAsync(chatId: msg.Chat.Id,
                        photo: c.CryRandomization(),
                        caption: "За что вы так...");
                }
                else if (lower.Contains("прив"))
                {
                    stream.Position = 0;
                    emo = 30;
                    await bot.SendPhotoAsync(chatId: msg.Chat.Id,
                        parseMode: Telegram.Bot.Types.Enums.ParseMode.Html,
                        photo: n.NeuRandomization(),
                        caption: "Здравствуйте.");
                }
                else if (lower.Contains("дура"))
                {
                    stream.Position = 0;
                    emo = 20;
                    await bot.SendPhotoAsync(chatId: msg.Chat.Id,
                        photo: a.AngryRandomization(),
                        caption: "Сам дурак!");
                }
                else if (lower.Contains("смеш"))
                {
                    stream.Position = 0;
                    emo = 85;
                    await bot.SendPhotoAsync(chatId: msg.Chat.Id,
                        photo: h.HappyRandomization(),
                        caption: "Хаха!");
                }
                else if (lower.Contains("колобок"))
                {
                    stream.Position = 0;
                    emo = 30;
                    await bot.SendPhotoAsync(chatId: msg.Chat.Id,
                        photo: s.SadRandomization(),
                        caption: "Почему же он повесился...");
                }
                
                else if (lower.Contains("кристи"))
                {
                    stream.Position = 0;
                    emo = 20;
                    await bot.SendPhotoAsync(chatId: msg.Chat.Id,
                        photo: a.AngryRandomization(),
                        caption: "Не называй меня Кристиной!");
                }
                else
                {
                    stream.Position = 0;
                    emo = 50;
                    await bot.SendPhotoAsync(chatId: msg.Chat.Id,
                        photo: s.SadRandomization(),
                        caption: "Извините, но я пока ещё не научилась отвечать на всё.");
                }
            }        
        }      
    }
}