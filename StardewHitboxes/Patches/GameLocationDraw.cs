using HarmonyLib;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StardewValley;
using System;

namespace StardewHitboxes.Patches
{
    [HarmonyPatch(typeof(GameLocation), "draw")]
    internal class GameLocationDraw
    {
        public static void Postfix(GameLocation __instance, SpriteBatch b)
        {
            if (!ModEntry.ShouldShowHitboxes())
                return;

            foreach (Farmer farmer in __instance.farmers)
                ModEntry.DrawHitbox(b, farmer);

            foreach (Character character in __instance.characters)
                ModEntry.DrawHitbox(b, character);
        }
    }

    [HarmonyPatch(typeof(GameLocation), "damageMonster", new Type[] { typeof(Rectangle), typeof(int), typeof(int), typeof(bool), typeof(float), typeof(int), typeof(float), typeof(float), typeof(bool), typeof(Farmer) })]
    internal class GameLocationDamageMonster
    {
        public static void Postfix(Rectangle areaOfEffect)
        {
            ModEntry.RenderWeaponAOE(areaOfEffect);
        }
    }
}
