﻿using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DBZMOD.Items.Consumables.TestItems
{
    public class SSJMasteryTestItem : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 38;
            item.consumable = true;
            item.maxStack = 1;
            item.UseSound = SoundID.Item3;
            item.useStyle = 2;
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.value = 0;
            item.expert = true;
            item.potion = false;
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("SSJ Mastery Test Item");
            Tooltip.SetDefault("Manually Upgrades your ssj1 mastery. Each use increases it by 0.25");
        }


        public override bool UseItem(Player player)
        {
            MyPlayer.ModPlayer(player).MasteryLevel1 += 0.25f;
            return true;

        }
    }
}