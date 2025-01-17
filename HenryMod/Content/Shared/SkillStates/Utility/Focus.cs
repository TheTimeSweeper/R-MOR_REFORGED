﻿using RMORMod.Content.HANDSurvivor;
using RMORMod.Content.HANDSurvivor.Components.Body;
using RoR2;
using RoR2.Skills;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace EntityStates.RMOR.Utility
{
    public class BeginFocus : BeginOverclock
    {
        public static Texture2D texGaugeNemesis;
        public static Texture2D texGaugeArrowNemesis;
        public static new Material overlayMaterial;

        public override void LoadStats()
        {
            cancelDef = RMORMod.Content.Shared.SkillDefs.UtilityOverclockCancel;
            buffDef = RMORMod.Content.Shared.Buffs.NemesisFocus;
            gaugeInternal = texGaugeNemesis;
            gaugeArrowInternal = texGaugeArrowNemesis;
            internalOverlayMaterial = overlayMaterial;
        }

        //Disabling sprint feels terrible.
        /*public override void FixedUpdate()
        {
            if (base.characterBody) base.characterBody.isSprinting = false;
            base.FixedUpdate();
        }*/

        /*public override float ExtendBuff(float stopwatch, float extensionTime)
        {
            return stopwatch - 0.5f * extensionTime;
        }*/
    }
}
