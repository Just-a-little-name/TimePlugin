using Rocket.API;
using System;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Rocket.Unturned.Player;
using Rocket.Unturned.Chat;

namespace TimePlugin.Commands
{
    public class TimePluginCommands : IRocketCommand
    {      
        public AllowedCaller AllowedCaller => AllowedCaller.Both;
        public string Name => "fottime";

        public string Help => "";

        public string Syntax => "";

        public List<string> Aliases => new List<string>();

        public List<string> Permissions => new List<string>();

        public void Execute(IRocketPlayer caller, string[] command)
        {
            if(command.Length > 0)
            {
                UnturnedChat.Say(caller, "Invalid parameter", UnityEngine.Color.green);
            }
            else
            {
                var timezone = TimeZoneInfo.CreateCustomTimeZone( "1111111" , new TimeSpan(3, 0, 0), "2222222", "3333333" );
                var time = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, timezone);
                UnturnedChat.Say(caller, $"Time: {time}", UnityEngine.Color.green);
            }
        }
    }
}
