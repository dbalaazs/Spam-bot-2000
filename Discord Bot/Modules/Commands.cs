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
            bool isNum = Int32.TryParse(number, out int result);
            if (isNum == true)
            {
                if (result <= 100)
                {
                    await ReplyAsync("Got it boss :thumbsup:");
                    while (result > 0)
                    {
                        await ReplyAsync(message);
                        Thread.Sleep(1000);
                        result--;
                    }
                }
                else { await ReplyAsync("I can't shitpost over 100 messages bruv"); }
            }
            else { await ReplyAsync("You messed up something in the request boss"); }
        }
        [Command("shitpost")]
        public async Task ShitPost(string message, string number)
        {
            bool isNum = Int32.TryParse(number, out int result);
            if (isNum == true)
            {
                if (result <= 100)
                {
                    await ReplyAsync("Got it boss :thumbsup:");
                    while (result > 0)
                    {
                        await ReplyAsync(message);
                        Thread.Sleep(1000);
                        result--;
                    }
                }
                else { await ReplyAsync("I can't shitpost over 100 messages bruv"); }
            }
            else { await ReplyAsync("You messed up something in the request boss"); }
        }
        [Command("help")]
        public async Task Help()
        {
            await ReplyAsync("You can say ~sp or ~shitpost, and then put in your message (be careful not to put any spaces), then put in how many times to shitpost it. You can't go over 100!");
            await ReplyAsync("For example: ~sp fuck-you 20");
        }
    }
}
