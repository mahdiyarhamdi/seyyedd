using System;
using Microsoft.EntityFrameworkCore;
using BDP.Model;
using Microsoft.Data.SqlClient;
using System.Data;
using Telegram.Bot;
using Telegram.Bot.Requests;

namespace BDP.Bot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World, I'm SENJED Bot!");
            var myBot = new TelegramBotClient("915237055:AAFmezzouoXO9H_cu1w-SQvIWuWyhoshZN0");
            var me = myBot.MakeRequestAsync(new GetMeRequest()).Result;

            if (me == null)
            {
                Console.WriteLine("GetMe() FAILED. Do you forget to add your AccessToken to config.json?");
                Console.WriteLine("(Press ENTER to quit)");
                Console.ReadLine();
                return;
            }
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine(DateTime.Now + " {0} (@{1} {2}) connected!", me.FirstName, me.LastName, me.Username);
            Console.WriteLine("Find @{0} in Telegram and send him a message - it will be displayed here", me.Username);

            int offset = 0;
            while (true)
            {
                var updates = myBot.MakeRequestAsync(new GetUpdatesRequest() { Offset = offset }).Result;
                if (updates != null)
                {
                    foreach (var update in updates)
                    {
                        offset = update.Id + 1;
                        Console.WriteLine(update.Message.Text);
                    }
                }
            }
            Console.WriteLine("Bye! I think I was a good bot and I am.");
        }
    }
}
