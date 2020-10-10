using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.ConstrainedExecution;
using System.Threading;
using System.Linq;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.Entities;
using Microsoft.VisualBasic.CompilerServices;
using DSharpPlus.Net;
using DSharpPlus.EventArgs;

namespace discordbot
{
    class Program
    {
        static string token = "NzIxNTEwODE1NjE3OTA4ODU4.XuVoHg.T-lhI-vzUYu2GQ0I9xNlNpTQpCI";
        static DiscordClient discord = new DiscordClient(new DiscordConfiguration
        {
            Token = token,
            TokenType = TokenType.Bot
        });
        static void Main(string[] args)
        {
            discord.MessageCreated += async(e) =>
            {
                checking(e);
            };
            discord.ConnectAsync();
            Console.ReadLine();
        }
        static async void checking(MessageCreateEventArgs e)
        {
            if (new Random().Next(0,101) >= 50)
            {
                discord.SendMessageAsync(e.Channel, new string[] { "Че с деньгами? я не понял???", "В смысле нету?", "Алло блять?", "Как там с деньгами?", "Алло?" }[new Random().Next(0,4)]);
            }
        }
    }
}
