﻿using System;

namespace SabberStonePowerLog
{
    internal class PowerBlockStart : PowerHistoryEntry
    {
        public PowerBlockStart()
        {
        }

        public object BlockType { get; internal set; }

        public override void Process(PowerGame powerGame)
        {
            throw new NotImplementedException();
        }
    }
}