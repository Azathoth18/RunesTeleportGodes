using BepInEx.Configuration;

namespace RunesTeleportGodes
{
    public static class RunesTeleportGodesConfig
    {
        private static ConfigFile _config;

        public static ConfigEntry<bool> EnableDebugMode;

        // ===== Runa T1 =====
        public static ConfigEntry<bool> RunaT1_CraftEnabled;
        public static ConfigEntry<bool> RunaT1_BossDropEnabled;
        public static ConfigEntry<string> RunaT1_BossPrefab;
        public static ConfigEntry<float> RunaT1_BossDropChance;
        public static ConfigEntry<int> RunaT1_BossDropAmount;
        public static ConfigEntry<float> RunaT1_Cooldown;
        public static ConfigEntry<float> RunaT1_Weight;
        public static ConfigEntry<string> RunaT1_CraftStation;
        public static ConfigEntry<int> RunaT1_MinStationLevel;
        public static ConfigEntry<string> RunaT1_RecipeString;
        public static ConfigEntry<string> RunaT1_AllowedItemsCSV;

        // ===== Runa T2 =====
        public static ConfigEntry<bool> RunaT2_CraftEnabled;
        public static ConfigEntry<bool> RunaT2_BossDropEnabled;
        public static ConfigEntry<string> RunaT2_BossPrefab;
        public static ConfigEntry<float> RunaT2_BossDropChance;
        public static ConfigEntry<int> RunaT2_BossDropAmount;
        public static ConfigEntry<float> RunaT2_Cooldown;
        public static ConfigEntry<float> RunaT2_Weight;
        public static ConfigEntry<string> RunaT2_CraftStation;
        public static ConfigEntry<int> RunaT2_MinStationLevel;
        public static ConfigEntry<string> RunaT2_RecipeString;
        public static ConfigEntry<string> RunaT2_AllowedItemsCSV;

        // RunaT3 Configurations
        public static ConfigEntry<bool> RunaT3_CraftEnabled;
        public static ConfigEntry<bool> RunaT3_BossDropEnabled;
        public static ConfigEntry<string> RunaT3_BossPrefab;
        public static ConfigEntry<float> RunaT3_BossDropChance;
        public static ConfigEntry<int> RunaT3_BossDropAmount;
        public static ConfigEntry<float> RunaT3_Cooldown;
        public static ConfigEntry<float> RunaT3_Weight;
        public static ConfigEntry<string> RunaT3_CraftStation;
        public static ConfigEntry<int> RunaT3_MinStationLevel;
        public static ConfigEntry<string> RunaT3_RecipeString;
        public static ConfigEntry<string> RunaT3_AllowedItemsCSV;

        // RunaT4 Configurations
        public static ConfigEntry<bool> RunaT4_CraftEnabled;
        public static ConfigEntry<bool> RunaT4_BossDropEnabled;
        public static ConfigEntry<string> RunaT4_BossPrefab;
        public static ConfigEntry<float> RunaT4_BossDropChance;
        public static ConfigEntry<int> RunaT4_BossDropAmount;
        public static ConfigEntry<float> RunaT4_Cooldown;
        public static ConfigEntry<float> RunaT4_Weight;
        public static ConfigEntry<string> RunaT4_CraftStation;
        public static ConfigEntry<int> RunaT4_MinStationLevel;
        public static ConfigEntry<string> RunaT4_RecipeString;
        public static ConfigEntry<string> RunaT4_AllowedItemsCSV;

        // RunaT5 Configurations
        public static ConfigEntry<bool> RunaT5_CraftEnabled;
        public static ConfigEntry<bool> RunaT5_BossDropEnabled;
        public static ConfigEntry<string> RunaT5_BossPrefab;
        public static ConfigEntry<float> RunaT5_BossDropChance;
        public static ConfigEntry<int> RunaT5_BossDropAmount;
        public static ConfigEntry<float> RunaT5_Cooldown;
        public static ConfigEntry<float> RunaT5_Weight;
        public static ConfigEntry<string> RunaT5_CraftStation;
        public static ConfigEntry<int> RunaT5_MinStationLevel;
        public static ConfigEntry<string> RunaT5_RecipeString;
        public static ConfigEntry<string> RunaT5_AllowedItemsCSV;

        // RunaT6 Configurations
        public static ConfigEntry<bool> RunaT6_CraftEnabled;
        public static ConfigEntry<bool> RunaT6_BossDropEnabled;
        public static ConfigEntry<string> RunaT6_BossPrefab;
        public static ConfigEntry<float> RunaT6_BossDropChance;
        public static ConfigEntry<int> RunaT6_BossDropAmount;
        public static ConfigEntry<float> RunaT6_Cooldown;
        public static ConfigEntry<float> RunaT6_Weight;
        public static ConfigEntry<string> RunaT6_CraftStation;
        public static ConfigEntry<int> RunaT6_MinStationLevel;
        public static ConfigEntry<string> RunaT6_RecipeString;
        public static ConfigEntry<string> RunaT6_AllowedItemsCSV;

        // RunaT7 Configurations
        public static ConfigEntry<bool> RunaT7_CraftEnabled;
        public static ConfigEntry<bool> RunaT7_BossDropEnabled;
        public static ConfigEntry<string> RunaT7_BossPrefab;
        public static ConfigEntry<float> RunaT7_BossDropChance;
        public static ConfigEntry<int> RunaT7_BossDropAmount;
        public static ConfigEntry<float> RunaT7_Cooldown;
        public static ConfigEntry<float> RunaT7_Weight;
        public static ConfigEntry<string> RunaT7_CraftStation;
        public static ConfigEntry<int> RunaT7_MinStationLevel;
        public static ConfigEntry<string> RunaT7_RecipeString;
        public static ConfigEntry<string> RunaT7_AllowedItemsCSV;

        public static void Initialize(ConfigFile config)
        {
            _config = config;
            _config.SaveOnConfigSet = true;
            CreateConfigValues();
        }

        private static void CreateConfigValues()
        {
            EnableDebugMode = _config.Bind(
                "General",
                "EnableDebugMode",
                false,
                "Habilita el registro de depuración para RunesTeleportGodes."
            );

            // == Runa T1 ==
            RunaT1_CraftEnabled = _config.Bind("RunaT1", "CraftEnabled", true, "¿Se craftea la runa T1?");
            RunaT1_BossDropEnabled = _config.Bind("RunaT1", "BossDropEnabled", false, "¿La runa T1 la suelta un boss?");
            RunaT1_BossPrefab = _config.Bind("RunaT1", "BossPrefab", "Eikthyr", "Boss que suelta RunaT1.");
            RunaT1_BossDropChance = _config.Bind("RunaT1", "BossDropChance", 1.0f, "Prob (0..1) de dropear T1.");
            RunaT1_BossDropAmount = _config.Bind("RunaT1", "BossDropAmount", 1, "Cantidad de RunaT1 que suelta el boss.");
            RunaT1_Cooldown = _config.Bind("RunaT1", "CooldownSeconds", 180f, "Cooldown (seg) de la runa T1.");
            RunaT1_Weight = _config.Bind("RunaT1", "Weight", 0.5f, "Peso de la runa T1.");
            RunaT1_CraftStation = _config.Bind("RunaT1", "CraftStation", "piece_workbench", "Estación de crafteo p/T1.");
            RunaT1_MinStationLevel = _config.Bind("RunaT1", "MinStationLevel", 1, "Nivel mínimo estación p/T1.");
            RunaT1_RecipeString = _config.Bind("RunaT1", "RecipeString", "Wood:100,Resin:100", "Receta T1, formato 'Mat:Qty,Mat2:Qty'");
            RunaT1_AllowedItemsCSV = _config.Bind("RunaT1", "AllowedItemsCSV", "", "Ítems no teleporteables permitidos en T1.");

            // == Runa T2 ==
            RunaT2_CraftEnabled = _config.Bind("RunaT2", "CraftEnabled", true, "¿Se craftea la runa T2?");
            RunaT2_BossDropEnabled = _config.Bind("RunaT2", "BossDropEnabled", false, "¿La runa T2 la suelta un boss?");
            RunaT2_BossPrefab = _config.Bind("RunaT2", "BossPrefab", "Eikthyr", "Boss que suelta RunaT2.");
            RunaT2_BossDropChance = _config.Bind("RunaT2", "BossDropChance", 1.0f, "Prob (0..1) de dropear T2.");
            RunaT2_BossDropAmount = _config.Bind("RunaT2", "BossDropAmount", 1, "Cantidad de RunaT2 que suelta el boss.");
            RunaT2_Cooldown = _config.Bind("RunaT2", "CooldownSeconds", 300f, "Cooldown (seg) de la runa T2.");
            RunaT2_Weight = _config.Bind("RunaT2", "Weight", 0.7f, "Peso de la runa T2.");
            RunaT2_CraftStation = _config.Bind("RunaT2", "CraftStation", "forge", "Estación de crafteo p/T2.");
            RunaT2_MinStationLevel = _config.Bind("RunaT2", "MinStationLevel", 1, "Nivel mínimo estación p/T2.");
            RunaT2_RecipeString = _config.Bind("RunaT2", "RecipeString", "TrophyEikthyr:5,Bronze:20", "Receta T2, formato 'Mat:Qty,Mat2:Qty'");
            RunaT2_AllowedItemsCSV = _config.Bind("RunaT2", "AllowedItemsCSV", "TinOre,Tin,CopperOre,CopperScrap,chest_hildir1,Copper,Bronze", "Ítems no teleporteables permitidos en T2.");

            // == Runa T3 ==
            RunaT3_CraftEnabled = _config.Bind("RunaT3", "CraftEnabled", true, "¿Se craftea la runa T3?");
            RunaT3_BossDropEnabled = _config.Bind("RunaT3", "BossDropEnabled", false, "¿La runa T3 la suelta un boss?");
            RunaT3_BossPrefab = _config.Bind("RunaT3", "BossPrefab", "gd_king", "Boss que suelta RunaT3.");
            RunaT3_BossDropChance = _config.Bind("RunaT3", "BossDropChance", 1.0f, "Prob (0..1) de dropear T3.");
            RunaT3_BossDropAmount = _config.Bind("RunaT3", "BossDropAmount", 1, "Cantidad de RunaT3 que suelta el boss.");
            RunaT3_Cooldown = _config.Bind("RunaT3", "CooldownSeconds", 480f, "Cooldown (seg) de la runa T3.");
            RunaT3_Weight = _config.Bind("RunaT3", "Weight", 0.7f, "Peso de la runa T3.");
            RunaT3_CraftStation = _config.Bind("RunaT3", "CraftStation", "forge", "Estación de crafteo p/T3.");
            RunaT3_MinStationLevel = _config.Bind("RunaT3", "MinStationLevel", 3, "Nivel mínimo estación p/T3.");
            RunaT3_RecipeString = _config.Bind("RunaT3", "RecipeString", "TrophyTheElder:5,Iron:20", "Receta T3, formato 'Mat:Qty,Mat2:Qty'");
            RunaT3_AllowedItemsCSV = _config.Bind("RunaT3", "AllowedItemsCSV", "TinOre,Tin,CopperOre,CopperScrap,chest_hildir1,Copper,Bronze,Ironpit,IronOre,IronScrap,Iron", "Ítems no teleporteables permitidos en T3.");

            // == Runa T4 ==
            RunaT4_CraftEnabled = _config.Bind("RunaT4", "CraftEnabled", true, "¿Se craftea la runa T4?");
            RunaT4_BossDropEnabled = _config.Bind("RunaT4", "BossDropEnabled", false, "¿La runa T4 la suelta un boss?");
            RunaT4_BossPrefab = _config.Bind("RunaT4", "BossPrefab", "Bonemass", "Boss que suelta RunaT4.");
            RunaT4_BossDropChance = _config.Bind("RunaT4", "BossDropChance", 1.0f, "Prob (0..1) de dropear T4.");
            RunaT4_BossDropAmount = _config.Bind("RunaT4", "BossDropAmount", 1, "Cantidad de RunaT4 que suelta el boss.");
            RunaT4_Cooldown = _config.Bind("RunaT4", "CooldownSeconds", 600f, "Cooldown (seg) de la runa T4.");
            RunaT4_Weight = _config.Bind("RunaT4", "Weight", 0.7f, "Peso de la runa T4.");
            RunaT4_CraftStation = _config.Bind("RunaT4", "CraftStation", "forge", "Estación de crafteo p/T4.");
            RunaT4_MinStationLevel = _config.Bind("RunaT4", "MinStationLevel", 4, "Nivel mínimo estación p/T4.");
            RunaT4_RecipeString = _config.Bind("RunaT4", "RecipeString", "TrophyBonemass:5,Guck:30", "Receta T4, formato 'Mat:Qty,Mat2:Qty'");
            RunaT4_AllowedItemsCSV = _config.Bind("RunaT4", "AllowedItemsCSV", "TinOre,Tin,CopperOre,CopperScrap,chest_hildir1,Copper,Bronze,Ironpit,IronOre,IronScrap,Iron,Silver,SilverOre,DragonEgg,chest_hildir2", "Ítems no teleporteables permitidos en T4.");

            // == Runa T5 ==
            RunaT5_CraftEnabled = _config.Bind("RunaT5", "CraftEnabled", true, "¿Se craftea la runa T5?");
            RunaT5_BossDropEnabled = _config.Bind("RunaT5", "BossDropEnabled", false, "¿La runa T5 la suelta un boss?");
            RunaT5_BossPrefab = _config.Bind("RunaT5", "BossPrefab", "Dragon", "Boss que suelta RunaT5.");
            RunaT5_BossDropChance = _config.Bind("RunaT5", "BossDropChance", 1.0f, "Prob (0..1) de dropear T5.");
            RunaT5_BossDropAmount = _config.Bind("RunaT5", "BossDropAmount", 1, "Cantidad de RunaT5 que suelta el boss.");
            RunaT5_Cooldown = _config.Bind("RunaT5", "CooldownSeconds", 780f, "Cooldown (seg) de la runa T5.");
            RunaT5_Weight = _config.Bind("RunaT5", "Weight", 0.7f, "Peso de la runa T5.");
            RunaT5_CraftStation = _config.Bind("RunaT5", "CraftStation", "piece_artisanstation", "Estación de crafteo p/T5.");
            RunaT5_MinStationLevel = _config.Bind("RunaT5", "MinStationLevel", 1, "Nivel mínimo estación p/T5.");
            RunaT5_RecipeString = _config.Bind("RunaT5", "RecipeString", "TrophyDragonQueen:5,DragonEgg:5", "Receta T5, formato 'Mat:Qty,Mat2:Qty'");
            RunaT5_AllowedItemsCSV = _config.Bind("RunaT5", "AllowedItemsCSV", "TinOre,Tin,CopperOre,CopperScrap,chest_hildir1,Copper,Bronze,Ironpit,IronOre,IronScrap,Iron,Silver,SilverOre,DragonEgg,chest_hildir2,BlackMetalScrap,BlackMetal,chest_hildir3", "Ítems no teleporteables permitidos en T5.");

            // == Runa T6 ==
            RunaT6_CraftEnabled = _config.Bind("RunaT6", "CraftEnabled", true, "¿Se craftea la runa T6?");
            RunaT6_BossDropEnabled = _config.Bind("RunaT6", "BossDropEnabled", false, "¿La runa T6 la suelta un boss?");
            RunaT6_BossPrefab = _config.Bind("RunaT6", "BossPrefab", "GoblinKing", "Boss que suelta RunaT6.");
            RunaT6_BossDropChance = _config.Bind("RunaT6", "BossDropChance", 1.0f, "Prob (0..1) de dropear T6.");
            RunaT6_BossDropAmount = _config.Bind("RunaT6", "BossDropAmount", 1, "Cantidad de RunaT6 que suelta el boss.");
            RunaT6_Cooldown = _config.Bind("RunaT6", "CooldownSeconds", 900f, "Cooldown (seg) de la runa T6.");
            RunaT6_Weight = _config.Bind("RunaT6", "Weight", 0.7f, "Peso de la runa T6.");
            RunaT6_CraftStation = _config.Bind("RunaT6", "CraftStation", "blackforge", "Estación de crafteo p/T6.");
            RunaT6_MinStationLevel = _config.Bind("RunaT6", "MinStationLevel", 1, "Nivel mínimo estación p/T6.");
            RunaT6_RecipeString = _config.Bind("RunaT6", "RecipeString", "TrophyGoblinKing:5,BlackMetal:20", "Receta T6, formato 'Mat:Qty,Mat2:Qty'");
            RunaT6_AllowedItemsCSV = _config.Bind("RunaT6", "AllowedItemsCSV", "TinOre,Tin,CopperOre,CopperScrap,chest_hildir1,Copper,Bronze,Ironpit,IronOre,IronScrap,Iron,Silver,SilverOre,DragonEgg,chest_hildir2,BlackMetalScrap,BlackMetal,chest_hildir3,DvergrNeedle,CharredCogwheel,Ironpit,MechanicalSpring", "Ítems no teleporteables permitidos en T6.");

            // == Runa T7 ==
            RunaT7_CraftEnabled = _config.Bind("RunaT7", "CraftEnabled", true, "¿Se craftea la runa T7?");
            RunaT7_BossDropEnabled = _config.Bind("RunaT7", "BossDropEnabled", false, "¿La runa T7 la suelta un boss?");
            RunaT7_BossPrefab = _config.Bind("RunaT7", "BossPrefab", "SeekerQueen", "Boss que suelta RunaT7.");
            RunaT7_BossDropChance = _config.Bind("RunaT7", "BossDropChance", 1.0f, "Prob (0..1) de dropear T7.");
            RunaT7_BossDropAmount = _config.Bind("RunaT7", "BossDropAmount", 1, "Cantidad de RunaT7 que suelta el boss.");
            RunaT7_Cooldown = _config.Bind("RunaT7", "CooldownSeconds", 1200f, "Cooldown (seg) de la runa T7.");
            RunaT7_Weight = _config.Bind("RunaT7", "Weight", 0.7f, "Peso de la runa T7.");
            RunaT7_CraftStation = _config.Bind("RunaT7", "CraftStation", "blackforge", "Estación de crafteo p/T7.");
            RunaT7_MinStationLevel = _config.Bind("RunaT7", "MinStationLevel", 2, "Nivel mínimo estación p/T7.");
            RunaT7_RecipeString = _config.Bind("RunaT7", "RecipeString", "TrophySeekerQueen:5,BlackMarble:20", "Receta T7, formato 'Mat:Qty,Mat2:Qty'");
            RunaT7_AllowedItemsCSV = _config.Bind("RunaT7", "AllowedItemsCSV", "TinOre,Tin,CopperOre,CopperScrap,chest_hildir1,Copper,Bronze,Ironpit,IronOre,IronScrap,Iron,Silver,SilverOre,DragonEgg,chest_hildir2,BlackMetalScrap,BlackMetal,chest_hildir3,DvergrNeedle,CharredCogwheel,Ironpit,MechanicalSpring,FlametalNew,FlametalOreNew", "Ítems no teleporteables permitidos en T7.");

        }
    }
}
