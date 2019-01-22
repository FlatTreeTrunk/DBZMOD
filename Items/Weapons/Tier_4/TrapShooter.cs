﻿using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DBZMOD.Items.Weapons.Tier_4
{
    public class TrapShooter : KiItem
    {
        public override void SetDefaults()
        {
            item.shoot = mod.ProjectileType("TrapShooterProjectile");
            item.shootSpeed = 35f;
            item.damage = 82;
            item.knockBack = 3f;
            item.useStyle = 5;
            item.UseSound = SoundID.Item1;
            item.useAnimation = 15;
            item.useTime = 15;
            item.width = 40;
            item.noUseGraphic = true;
            item.height = 40;
            item.autoReuse = false;
            item.value = 27000;
            item.rare = 4;
            kiDrain = 115;
            weaponType = "Blast";
        }
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Trap Shooter");
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(15));
            speedX = perturbedSpeed.X;
            speedY = perturbedSpeed.Y;
            return true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "AngerKiCrystal", 35);
            recipe.AddIngredient(null, "SoulofEntity", 15);
            recipe.AddTile(null, "ZTable");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
