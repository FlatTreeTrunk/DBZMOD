﻿using DBZMOD.Util;
using Terraria;

namespace DBZMOD.Buffs.SSJBuffs
{
    public class USSJBuff : TransformationBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault(FormBuffHelper.GetUSSJNamePreference());
            Main.buffNoTimeDisplay[Type] = true;
            Main.buffNoSave[Type] = true;
            Main.debuff[Type] = false;
            damageMulti = 1.90f;
            speedMulti = 0.9f;
            kiDrainRate = 1.5f;
            kiDrainRateWithMastery = 0.75f;
            kiDrainBuffMulti = 1.6f;
            baseDefenceBonus = 6;
            Description.SetDefault(AssembleTransBuffDescription());
        }
    }
}

