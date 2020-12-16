using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;

namespace DiscordBot.Modules
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        [Command("sp")]
        
        public async Task Sp(string message, string number)
        {
            await ReplyAsync("Got it boss :thumbsup:");
            bool isNum = Int32.TryParse(number, out int result);
            if (isNum == true)
            {
                if (result <= 100)
                {
                    while (result > 0)
                    {
                        await ReplyAsync(message);
                        Thread.Sleep(1000);
                        result--;
                    }
                }
                else { await ReplyAsync("I can't shitpost over 100 messages bruv"); }
            }      
        }
        [Command("shitpost")]
        public async Task ShitPost(string message, string number)
        {
            await ReplyAsync("Got it boss :thumbsup:");
            bool isNum = Int32.TryParse(number, out int result);
            if (isNum == true)
            {
                if (result <= 100)
                {
                    while (result > 0)
                    {
                        await ReplyAsync(message);
                        Thread.Sleep(1000);
                        result--;
                    }
                }
                else { await ReplyAsync("I can't shitpost over 100 messages bruv"); }
            }
        }
    }
}