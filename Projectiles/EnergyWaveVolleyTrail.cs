﻿using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;

namespace DBZMOD.Projectiles
{
    public class EnergyWaveVolleyTrail : KiProjectile
    {
    	public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("EnergyWaveVolleyTrail");
		}
    	
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.SwordBeam);
            projectile.hostile = false;
            projectile.friendly = true;
			projectile.tileCollide = false;
            projectile.width = 20;
            projectile.height = 28;
			projectile.aiStyle = 1;
			projectile.light = 1f;
			projectile.timeLeft = 30;
            projectile.knockBack = defaultBeamKnockback;
            projectile.netUpdate = true;
            aiType = 14;
            projectile.ignoreWater = true;
			projectile.penetrate = -1;
            beamTrail = true;
			ProjectileID.Sets.TrailCacheLength[projectile.type] = 7;
            ProjectileID.Sets.TrailingMode[projectile.type] = 0;
        }
		
		public override void AI()
        {   
            projectile.rotation = projectile.ai[1]; 
            projectile.localAI[0] += 1f;
            projectile.alpha = (int)projectile.localAI[0] * 2;
            
            if (projectile.localAI[0] > 130f)
            {
                projectile.Kill();
            }
           
        }
		
		public override bool PreDraw(SpriteBatch spriteBatch, Color lightColor)
		{
			Vector2 drawOrigin = new Vector2(Main.projectileTexture[projectile.type].Width * 0.5f, projectile.height * 0.5f);
			for (int k = 0; k < projectile.oldPos.Length; k++)
			{
				Vector2 drawPos = projectile.oldPos[k] - Main.screenPosition + drawOrigin + new Vector2(0f, projectile.gfxOffY);
				Color color = projectile.GetAlpha(lightColor) * ((float)(projectile.oldPos.Length - k) / (float)projectile.oldPos.Length);
				spriteBatch.Draw(Main.projectileTexture[projectile.type], drawPos, null, color, projectile.rotation, drawOrigin, projectile.scale, SpriteEffects.None, 0f);
			}
			return true;
		}
	}
}