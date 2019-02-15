﻿using Terraria;
using Terraria.ModLoader;

namespace DBZMOD.Buffs
{
    public class SenzuCooldown : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Senzu Cooldown");
            Description.SetDefault("You feel too sick to eat another senzu.");
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = true;
        }
    }
}
