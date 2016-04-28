﻿using DiscordSharp.Events;
using Miki.Core;
using System;

namespace Miki.Extensions.Cage
{
    class Cage_Discord:Command
    {
        Random r = new Random();

        String[] number1 = new String[]
        {
            "100",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000",
            "1200",
            "1300",
            "1400",
            "1500",
        };

        String[] number2 = new String[]
        {
            "100",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000",
            "1100",
            "1200",
            "1300",
            "1400",
            "1500",
        };


        public override void Initialize()
        {
            id = "cage";
            appearInHelp = true;
            description = "Summon Nicholas Cage";

            base.Initialize();
        }

         protected override void PlayCommand(DiscordMessageEventArgs e)
        {
            base.PlayCommand(e);
            e.Channel.SendMessage("http://www.placecage.com/c/" + number1[r.Next(0, number1.Length)] + "/" + number2[r.Next(0, number2.Length)]);
        }
    }
}