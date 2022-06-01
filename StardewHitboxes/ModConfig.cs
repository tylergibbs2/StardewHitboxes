﻿using StardewModdingAPI.Utilities;

namespace StardewHitboxes
{
    public class ModConfig
    {
        public bool Enabled { get; set; } = true;

        public KeybindList ToggleKey { get; set; } = KeybindList.Parse("F2");

        public string FarmerHitboxColor { get; set; } = "#32CD32";

        public string CharacterHitboxColor { get; set; } = "#BF40BF";

        public string MonsterHitboxColor { get; set; } = "#FF0000";

        public string WeaponSwingHitboxColor { get; set; } = "#FFA500";

        public float HitboxOpacity { get; set; } = 0.6f;
    }
}