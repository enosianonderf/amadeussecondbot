using Telegram.Bot;
using Telegram.Bot.Args;
using System;

namespace amadeus2
{
    class ASB
// Токен и определение самого бота
    {
        
        private static string token { get; set; } = "2008109914:AAFi-o9eFEgMaLO8k22F9Tmq4BmzwiROkLI";
        private static TelegramBotClient bot;
        static void Main(string[] args)
        {
            Console.WriteLine("Запуск бота...");
            
            bot = new TelegramBotClient(token);
            bot.OnMessage += BotOnOnMessage;
            bot.StartReceiving();
            Console.ReadLine();
        }
        private static async void BotOnOnMessage(object? sender, MessageEventArgs e)
        {
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
                    await bot.SendTextMessageAsync(msg.Chat.Id, "Здравствуйте.");
                }
            }
        

        }

           
          
       
    }


}