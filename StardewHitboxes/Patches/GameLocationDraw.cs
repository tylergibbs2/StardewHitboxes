using HarmonyLib;
using Microsoft.Xna.Framework.Graphics;
using StardewValley;

namespace StardewHitboxes.Patches
{
    [HarmonyPatch(typeof(GameLocation), "draw")]
    internal class GameLocationDraw
    {
        public static void Postfix(GameLocation __instance, SpriteBatch b)
        {
            foreach (Farmer farmer in __instance.farmers)
                ModEntry.DrawHitbox(b, farmer);

            foreach (Character character in __instance.characters)
                ModEntry.DrawHitbox(b, character);
        }
    }
}
