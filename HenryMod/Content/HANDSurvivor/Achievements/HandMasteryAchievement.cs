﻿using RoR2;
using RoR2.Achievements;
using UnityEngine;

namespace HAND_Junked.Content.HANDSurvivor.Achievements
{
    [RegisterAchievement("MoffeinHANDOverclockedClearGameMonsoon", "Skins.HANDOverclocked.Mastery", null, null)]
    public class RMORMasteryAchievement : BasePerSurvivorClearGameMonsoonAchievement
    {
        public override BodyIndex LookUpRequiredBodyIndex()
        {
            return BodyCatalog.FindBodyIndex("HANDOverclockedBody");
        }
    }
}
