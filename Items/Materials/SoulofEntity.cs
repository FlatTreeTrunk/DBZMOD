﻿using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace DBZMOD.Items.Materials
{
    public class SoulofEntity : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Soul of Entity");
            Tooltip.SetDefault("'The soul of a reanimated foe.'");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(5, 4)); //5 = ticks per frame change, 4 = number of frames
            ItemID.Sets.AnimatesAsSoul[item.type] = true;
            ItemID.Sets.ItemIconPulse[item.type] = true;
            ItemID.Sets.ItemNoGravity[item.type] = true;
        }

        public override void SetDefaults()
        {
            Item refItem = new Item();
            refItem.SetDefaults(ItemID.SoulofSight);
            item.width = refItem.width;
            item.height = refItem.height;
            item.maxStack = 999;
            item.value = 520;
            item.rare = 5;
        }

	    public override Color? GetAlpha(Color lightColor)
        {
            return Color.White;
        }
    }
}