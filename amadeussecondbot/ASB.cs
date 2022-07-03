using Telegram.Bot;
using Telegram.Bot.Args;
using System.Net;

namespace amadeus2
{
    class ASB
// Токен и определение самого бота
    {
        public static string emostatus;
        public static int send = 0;
        public static int emo = 50;
        


        private static string token { get; set; } = "2008109914:AAFi-o9eFEgMaLO8k22F9Tmq4BmzwiROkLI";
        private static TelegramBotClient bot;
        static void Main(string[] args)
        {
            
           

            DateTime now = DateTime.Now;
            Console.WriteLine("Запуск бота...");
     
            if (false)
            {
                Console.WriteLine($"{now.ToString("HH")}");
            }
            Console.WriteLine($"Инициализация бота {now:T}");
            WebClient Client = new WebClient();
            String Response;
            try
            {   
                Response = Client.DownloadString("http://test.vkgroup.az/");
                if (Response != null)
                {
                    DateTime snow = DateTime.Now;
                    Console.WriteLine("Запуск успешен! Бот находится в исправно-активном состоянии.");
                    Console.WriteLine($"Бот запущен {snow:R}");
                }

            }
            catch
            {
                DateTime snow = DateTime.Now;
                Console.WriteLine("Запуск бота провален.");
                Console.WriteLine($"Бот не работает. Попробуйте подключиться позже. {snow:R}");
            }
            

            bot = new TelegramBotClient(token);
            bot.OnMessage += BotOnOnMessage;
            bot.StartReceiving();
            

            

            Console.ReadLine();
            
        }


        
        private static async void BotOnOnMessage(object? sender, MessageEventArgs e)
        {
            RandomSmile sm = new();
            RandomAngry a = new();
            RandomHappy h = new();
            RandomSad s = new();
            RandomCry c = new();
            RandomNeu n = new();
            RandomEmb emb = new();
            Random rannum = new Random();
            emosres emosresult = new();
            phrases ph = new();
            using var stream = new MemoryStream();
            
            var msg = e.Message;
            var lower = msg.Text.ToLower();
            
            if (msg.Text != null)
            {


                string captionres = " ";
                int rannum2 = rannum.Next(5, 10);
                Console.WriteLine($"Введено : {msg.Text} от {msg.Chat.Id}");
                if (lower.Contains("ты") && lower.Contains("бот") && (rannum2 >= 5))
                
                {
                    stream.Position = 0;
                    emo = 5;
                    captionres = "За что вы так...";
                               
                }

                else if (lower.Contains("прив") || lower.Contains("добр") || lower.Contains("вечер") || lower.Contains("день") || lower.Contains("утро") && (rannum2 >= 5))
                {
                    stream.Position = 0;
                    emo = 80;
                    captionres = ph.phrandom();
                }

                else if (lower.Contains("дура") && (rannum2 >= 5))
                {
                    stream.Position = 0;
                    emo = 15;
                    captionres = "Сам дурак!";
                }
                
                else if (lower.Contains("смеш") && (rannum2 >= 5))
                {
                    stream.Position = 0;
                    emo = 85;
                    captionres = "Хаха!";

                }

                else if (lower.Contains("амадей") || lower.Contains("курису") && (rannum2 >= 5))
                {
                    stream.Position = 0;
                    emo = 76;
                    captionres = "Это.. Моё имя.";

                }

                else if (lower.Contains("колобок") && (rannum2 >= 5))
                {
                    stream.Position = 0;
                    emo = 25;
                    captionres = "Почему же он повесился...";
                }
                
                else if (lower.Contains("кристи") && (rannum2 >= 5))
                {
                    stream.Position = 0;
                    emo = 20;
                    captionres = "Не называй меня Кристиной!";
                }
                
                else if (lower.Contains("ты") && (lower.Contains("ложк")) && (rannum2 >= 5))
                {
                    stream.Position = 0;
                    emo = 65;
                    captionres = "Ч-что... Не понимаю, о чём вы!";
                }

                else if (lower.Contains("тебя") && (lower.Contains("люблю")) && (rannum2 >= 5))
                {
                    stream.Position = 0;
                    emo = 65;
                    captionres = "Я.. Я не понимаю таких чувств...";

                }

                else if (lower.Contains("/start"))
                {
                    stream.Position = 0;
                    emo = 80;
                    captionres = "Добро пожаловать на тестовую версию Амадеуса-1.";
                }
                else if (lower.Contains("/n1"))

                {
                    stream.Position = 0;
                    emo = 90;
                    captionres = "Включён режим постоянного общения.";
                }

                else
                {
                    if (rannum2 >= 5)
                    {
                        
                    
                        stream.Position = 0;
                        emo = 40;
                        captionres = "Извините, я ещё не научилась отвечать на такие слова.";
                    }
                    
                }
                if (emo >= 0 && emo < 10)
                {
                    emostatus = c.CryRandomization();

                }

                else if (emo <= 20 && emo >= 10)
                {
                    emostatus = a.AngryRandomization();

                }

                else if (emo >= 85 && emo <= 100)
                {
                    emostatus = h.HappyRandomization();

                }

                else if (emo < 50 && emo > 20)
                {
                    emostatus = s.SadRandomization();

                }

                else if (emo >= 50 && emo < 60)
                {
                    emostatus = n.NeuRandomization();

                }

                else if (emo >= 75 && emo < 85)
                {
                    emostatus = sm.SmileRandomization();

                }

                else if (emo >= 60 && emo < 75)
                {
                    emostatus = emb.EmbRandomization();

                }
                
                await bot.SendPhotoAsync(chatId: msg.Chat.Id,
                        photo: emostatus,
                        caption: captionres);
                
            }
        }      
    }
}