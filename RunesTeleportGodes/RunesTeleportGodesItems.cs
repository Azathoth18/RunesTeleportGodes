using HarmonyLib;
using Jotunn.Configs;
using Jotunn.Entities;
using Jotunn.Managers;
using Jotunn.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Logger = Jotunn.Logger;

namespace RunesTeleportGodes
{
    internal class RunesTeleportGodesItems
    {

        internal static Dictionary<string, RunaItemConfig> _runaConfigs = new Dictionary<string, RunaItemConfig>();
        internal static DateTime _globalNextUse = DateTime.MinValue;

        public RunesTeleportGodesItems(AssetBundle assetBundle)
        {
            // ============ RunaT1 ============
            RunaData t1 = new RunaData
            {
                Id = "RunaT1",
                PrefabName = "RunaT1",
                VfxName = "vfx_Celestial_heavy",
                SfxName = "sfx_runateleportsound",
                CooldownSec = RunesTeleportGodesConfig.RunaT1_Cooldown.Value,
                Weight = RunesTeleportGodesConfig.RunaT1_Weight.Value,
                CraftEnabled = RunesTeleportGodesConfig.RunaT1_CraftEnabled.Value,
                BossDropEnabled = RunesTeleportGodesConfig.RunaT1_BossDropEnabled.Value,
                BossPrefabName = RunesTeleportGodesConfig.RunaT1_BossPrefab.Value,
                BossDropChance = RunesTeleportGodesConfig.RunaT1_BossDropChance.Value,
                BossDropAmount = RunesTeleportGodesConfig.RunaT1_BossDropAmount.Value,
                CraftStation = RunesTeleportGodesConfig.RunaT1_CraftStation.Value,
                MinStationLevel = RunesTeleportGodesConfig.RunaT1_MinStationLevel.Value,
                RecipeString = RunesTeleportGodesConfig.RunaT1_RecipeString.Value,
                AllowedItemsCSV = RunesTeleportGodesConfig.RunaT1_AllowedItemsCSV.Value,
                IconFileName = "Runa_T1.png",
                // Nuevos campos para localización:
                NameCode = "RunaT1_name",
                DescriptionCode = "RunaT1_desc"
            };

            RegisterRuna(
                assetBundle,
                t1.Id,
                RunesTeleportGodesConfig.RunaT1_Cooldown,
                RunesTeleportGodesConfig.RunaT1_Weight,
                RunesTeleportGodesConfig.RunaT1_CraftEnabled,
                RunesTeleportGodesConfig.RunaT1_BossDropEnabled,
                RunesTeleportGodesConfig.RunaT1_BossPrefab,
                RunesTeleportGodesConfig.RunaT1_BossDropChance,
                RunesTeleportGodesConfig.RunaT1_BossDropAmount,
                RunesTeleportGodesConfig.RunaT1_CraftStation,
                RunesTeleportGodesConfig.RunaT1_MinStationLevel,
                RunesTeleportGodesConfig.RunaT1_RecipeString,
                RunesTeleportGodesConfig.RunaT1_AllowedItemsCSV,
                t1.PrefabName,
                t1.IconFileName,
                t1.VfxName,
                t1.SfxName,
                t1.NameCode,
                t1.DescriptionCode
            );

            // ============ RunaT2 ============
            RunaData t2 = new RunaData
            {
                Id = "RunaT2",
                PrefabName = "RunaT2",
                VfxName = "vfx_Celestial_heavy",
                SfxName = "sfx_runateleportsound",
                CooldownSec = RunesTeleportGodesConfig.RunaT2_Cooldown.Value,
                Weight = RunesTeleportGodesConfig.RunaT2_Weight.Value,
                CraftEnabled = RunesTeleportGodesConfig.RunaT2_CraftEnabled.Value,
                BossDropEnabled = RunesTeleportGodesConfig.RunaT2_BossDropEnabled.Value,
                BossPrefabName = RunesTeleportGodesConfig.RunaT2_BossPrefab.Value,
                BossDropChance = RunesTeleportGodesConfig.RunaT2_BossDropChance.Value,
                BossDropAmount = RunesTeleportGodesConfig.RunaT2_BossDropAmount.Value,
                CraftStation = RunesTeleportGodesConfig.RunaT2_CraftStation.Value,
                MinStationLevel = RunesTeleportGodesConfig.RunaT2_MinStationLevel.Value,
                RecipeString = RunesTeleportGodesConfig.RunaT2_RecipeString.Value,
                AllowedItemsCSV = RunesTeleportGodesConfig.RunaT2_AllowedItemsCSV.Value,
                IconFileName = "Runa_T2.png",
                // Nuevos campos para localización:
                NameCode = "RunaT2_name",
                DescriptionCode = "RunaT2_desc"
            };

            RegisterRuna(
                assetBundle,
                t2.Id,
                RunesTeleportGodesConfig.RunaT2_Cooldown,
                RunesTeleportGodesConfig.RunaT2_Weight,
                RunesTeleportGodesConfig.RunaT2_CraftEnabled,
                RunesTeleportGodesConfig.RunaT2_BossDropEnabled,
                RunesTeleportGodesConfig.RunaT2_BossPrefab,
                RunesTeleportGodesConfig.RunaT2_BossDropChance,
                RunesTeleportGodesConfig.RunaT2_BossDropAmount,
                RunesTeleportGodesConfig.RunaT2_CraftStation,
                RunesTeleportGodesConfig.RunaT2_MinStationLevel,
                RunesTeleportGodesConfig.RunaT2_RecipeString,
                RunesTeleportGodesConfig.RunaT2_AllowedItemsCSV,
                t2.PrefabName,
                t2.IconFileName,
                t2.VfxName,
                t2.SfxName,
                t2.NameCode,
                t2.DescriptionCode
            );

            // ============ RunaT3 ============
            RunaData t3 = new RunaData
            {
                Id = "RunaT3",
                PrefabName = "RunaT3",
                VfxName = "vfx_Celestial_heavy",
                SfxName = "sfx_runateleportsound",
                CooldownSec = RunesTeleportGodesConfig.RunaT3_Cooldown.Value,
                Weight = RunesTeleportGodesConfig.RunaT3_Weight.Value,
                CraftEnabled = RunesTeleportGodesConfig.RunaT3_CraftEnabled.Value,
                BossDropEnabled = RunesTeleportGodesConfig.RunaT3_BossDropEnabled.Value,
                BossPrefabName = RunesTeleportGodesConfig.RunaT3_BossPrefab.Value,
                BossDropChance = RunesTeleportGodesConfig.RunaT3_BossDropChance.Value,
                BossDropAmount = RunesTeleportGodesConfig.RunaT3_BossDropAmount.Value,
                CraftStation = RunesTeleportGodesConfig.RunaT3_CraftStation.Value,
                MinStationLevel = RunesTeleportGodesConfig.RunaT3_MinStationLevel.Value,
                RecipeString = RunesTeleportGodesConfig.RunaT3_RecipeString.Value,
                AllowedItemsCSV = RunesTeleportGodesConfig.RunaT3_AllowedItemsCSV.Value,
                IconFileName = "Runa_T3.png",
                // Nuevos campos para localización:
                NameCode = "RunaT3_name",
                DescriptionCode = "RunaT3_desc"
            };

            RegisterRuna(
                assetBundle,
                t3.Id,
                RunesTeleportGodesConfig.RunaT3_Cooldown,
                RunesTeleportGodesConfig.RunaT3_Weight,
                RunesTeleportGodesConfig.RunaT3_CraftEnabled,
                RunesTeleportGodesConfig.RunaT3_BossDropEnabled,
                RunesTeleportGodesConfig.RunaT3_BossPrefab,
                RunesTeleportGodesConfig.RunaT3_BossDropChance,
                RunesTeleportGodesConfig.RunaT3_BossDropAmount,
                RunesTeleportGodesConfig.RunaT3_CraftStation,
                RunesTeleportGodesConfig.RunaT3_MinStationLevel,
                RunesTeleportGodesConfig.RunaT3_RecipeString,
                RunesTeleportGodesConfig.RunaT3_AllowedItemsCSV,
                t3.PrefabName,
                t3.IconFileName,
                t3.VfxName,
                t3.SfxName,
                t3.NameCode,
                t3.DescriptionCode
            );

            // ============ RunaT4 ============
            RunaData t4 = new RunaData
            {
                Id = "RunaT4",
                PrefabName = "RunaT4",
                VfxName = "vfx_Celestial_heavy",
                SfxName = "sfx_runateleportsound",
                CooldownSec = RunesTeleportGodesConfig.RunaT4_Cooldown.Value,
                Weight = RunesTeleportGodesConfig.RunaT4_Weight.Value,
                CraftEnabled = RunesTeleportGodesConfig.RunaT4_CraftEnabled.Value,
                BossDropEnabled = RunesTeleportGodesConfig.RunaT4_BossDropEnabled.Value,
                BossPrefabName = RunesTeleportGodesConfig.RunaT4_BossPrefab.Value,
                BossDropChance = RunesTeleportGodesConfig.RunaT4_BossDropChance.Value,
                BossDropAmount = RunesTeleportGodesConfig.RunaT4_BossDropAmount.Value,
                CraftStation = RunesTeleportGodesConfig.RunaT4_CraftStation.Value,
                MinStationLevel = RunesTeleportGodesConfig.RunaT4_MinStationLevel.Value,
                RecipeString = RunesTeleportGodesConfig.RunaT4_RecipeString.Value,
                AllowedItemsCSV = RunesTeleportGodesConfig.RunaT4_AllowedItemsCSV.Value,
                IconFileName = "Runa_T4.png",
                // Nuevos campos para localización:
                NameCode = "RunaT4_name",
                DescriptionCode = "RunaT4_desc"
            };

            RegisterRuna(
                assetBundle,
                t4.Id,
                RunesTeleportGodesConfig.RunaT4_Cooldown,
                RunesTeleportGodesConfig.RunaT4_Weight,
                RunesTeleportGodesConfig.RunaT4_CraftEnabled,
                RunesTeleportGodesConfig.RunaT4_BossDropEnabled,
                RunesTeleportGodesConfig.RunaT4_BossPrefab,
                RunesTeleportGodesConfig.RunaT4_BossDropChance,
                RunesTeleportGodesConfig.RunaT4_BossDropAmount,
                RunesTeleportGodesConfig.RunaT4_CraftStation,
                RunesTeleportGodesConfig.RunaT4_MinStationLevel,
                RunesTeleportGodesConfig.RunaT4_RecipeString,
                RunesTeleportGodesConfig.RunaT4_AllowedItemsCSV,
                t4.PrefabName,
                t4.IconFileName,
                t4.VfxName,
                t4.SfxName,
                t4.NameCode,
                t4.DescriptionCode
            );

            // ============ RunaT5 ============
            RunaData t5 = new RunaData
            {
                Id = "RunaT5",
                PrefabName = "RunaT5",
                VfxName = "vfx_Celestial_heavy",
                SfxName = "sfx_runateleportsound",
                CooldownSec = RunesTeleportGodesConfig.RunaT5_Cooldown.Value,
                Weight = RunesTeleportGodesConfig.RunaT5_Weight.Value,
                CraftEnabled = RunesTeleportGodesConfig.RunaT5_CraftEnabled.Value,
                BossDropEnabled = RunesTeleportGodesConfig.RunaT5_BossDropEnabled.Value,
                BossPrefabName = RunesTeleportGodesConfig.RunaT5_BossPrefab.Value,
                BossDropChance = RunesTeleportGodesConfig.RunaT5_BossDropChance.Value,
                BossDropAmount = RunesTeleportGodesConfig.RunaT5_BossDropAmount.Value,
                CraftStation = RunesTeleportGodesConfig.RunaT5_CraftStation.Value,
                MinStationLevel = RunesTeleportGodesConfig.RunaT5_MinStationLevel.Value,
                RecipeString = RunesTeleportGodesConfig.RunaT5_RecipeString.Value,
                AllowedItemsCSV = RunesTeleportGodesConfig.RunaT5_AllowedItemsCSV.Value,
                IconFileName = "Runa_T5.png",
                // Nuevos campos para localización:
                NameCode = "RunaT5_name",
                DescriptionCode = "RunaT5_desc"
            };

            RegisterRuna(
                assetBundle,
                t5.Id,
                RunesTeleportGodesConfig.RunaT5_Cooldown,
                RunesTeleportGodesConfig.RunaT5_Weight,
                RunesTeleportGodesConfig.RunaT5_CraftEnabled,
                RunesTeleportGodesConfig.RunaT5_BossDropEnabled,
                RunesTeleportGodesConfig.RunaT5_BossPrefab,
                RunesTeleportGodesConfig.RunaT5_BossDropChance,
                RunesTeleportGodesConfig.RunaT5_BossDropAmount,
                RunesTeleportGodesConfig.RunaT5_CraftStation,
                RunesTeleportGodesConfig.RunaT5_MinStationLevel,
                RunesTeleportGodesConfig.RunaT5_RecipeString,
                RunesTeleportGodesConfig.RunaT5_AllowedItemsCSV,
                t5.PrefabName,
                t5.IconFileName,
                t5.VfxName,
                t5.SfxName,
                t5.NameCode,
                t5.DescriptionCode
            );
            // ============ RunaT6 ============
            RunaData t6 = new RunaData
            {
                Id = "RunaT6",
                PrefabName = "RunaT6",
                VfxName = "vfx_Celestial_heavy",
                SfxName = "sfx_runateleportsound",
                CooldownSec = RunesTeleportGodesConfig.RunaT6_Cooldown.Value,
                Weight = RunesTeleportGodesConfig.RunaT6_Weight.Value,
                CraftEnabled = RunesTeleportGodesConfig.RunaT6_CraftEnabled.Value,
                BossDropEnabled = RunesTeleportGodesConfig.RunaT6_BossDropEnabled.Value,
                BossPrefabName = RunesTeleportGodesConfig.RunaT6_BossPrefab.Value,
                BossDropChance = RunesTeleportGodesConfig.RunaT6_BossDropChance.Value,
                BossDropAmount = RunesTeleportGodesConfig.RunaT6_BossDropAmount.Value,
                CraftStation = RunesTeleportGodesConfig.RunaT6_CraftStation.Value,
                MinStationLevel = RunesTeleportGodesConfig.RunaT6_MinStationLevel.Value,
                RecipeString = RunesTeleportGodesConfig.RunaT6_RecipeString.Value,
                AllowedItemsCSV = RunesTeleportGodesConfig.RunaT6_AllowedItemsCSV.Value,
                IconFileName = "Runa_T6.png",
                // Nuevos campos para localización:
                NameCode = "RunaT6_name",
                DescriptionCode = "RunaT6_desc"
            };

            RegisterRuna(
                assetBundle,
                t6.Id,
                RunesTeleportGodesConfig.RunaT6_Cooldown,
                RunesTeleportGodesConfig.RunaT6_Weight,
                RunesTeleportGodesConfig.RunaT6_CraftEnabled,
                RunesTeleportGodesConfig.RunaT6_BossDropEnabled,
                RunesTeleportGodesConfig.RunaT6_BossPrefab,
                RunesTeleportGodesConfig.RunaT6_BossDropChance,
                RunesTeleportGodesConfig.RunaT6_BossDropAmount,
                RunesTeleportGodesConfig.RunaT6_CraftStation,
                RunesTeleportGodesConfig.RunaT6_MinStationLevel,
                RunesTeleportGodesConfig.RunaT6_RecipeString,
                RunesTeleportGodesConfig.RunaT6_AllowedItemsCSV,
                t6.PrefabName,
                t6.IconFileName,
                t6.VfxName,
                t6.SfxName,
                t6.NameCode,
                t6.DescriptionCode
            );
            // ============ RunaT7 ============
            RunaData t7 = new RunaData
            {
                Id = "RunaT7",
                PrefabName = "RunaT7",
                VfxName = "vfx_Celestial_heavy",
                SfxName = "sfx_runateleportsound",
                CooldownSec = RunesTeleportGodesConfig.RunaT7_Cooldown.Value,
                Weight = RunesTeleportGodesConfig.RunaT7_Weight.Value,
                CraftEnabled = RunesTeleportGodesConfig.RunaT7_CraftEnabled.Value,
                BossDropEnabled = RunesTeleportGodesConfig.RunaT7_BossDropEnabled.Value,
                BossPrefabName = RunesTeleportGodesConfig.RunaT7_BossPrefab.Value,
                BossDropChance = RunesTeleportGodesConfig.RunaT7_BossDropChance.Value,
                BossDropAmount = RunesTeleportGodesConfig.RunaT7_BossDropAmount.Value,
                CraftStation = RunesTeleportGodesConfig.RunaT7_CraftStation.Value,
                MinStationLevel = RunesTeleportGodesConfig.RunaT7_MinStationLevel.Value,
                RecipeString = RunesTeleportGodesConfig.RunaT7_RecipeString.Value,
                AllowedItemsCSV = RunesTeleportGodesConfig.RunaT7_AllowedItemsCSV.Value,
                IconFileName = "Runa_T7.png",
                // Nuevos campos para localización:
                NameCode = "RunaT7_name",
                DescriptionCode = "RunaT7_desc"
            };

            RegisterRuna(
                assetBundle,
                t7.Id,
                RunesTeleportGodesConfig.RunaT7_Cooldown,
                RunesTeleportGodesConfig.RunaT7_Weight,
                RunesTeleportGodesConfig.RunaT7_CraftEnabled,
                RunesTeleportGodesConfig.RunaT7_BossDropEnabled,
                RunesTeleportGodesConfig.RunaT7_BossPrefab,
                RunesTeleportGodesConfig.RunaT7_BossDropChance,
                RunesTeleportGodesConfig.RunaT7_BossDropAmount,
                RunesTeleportGodesConfig.RunaT7_CraftStation,
                RunesTeleportGodesConfig.RunaT7_MinStationLevel,
                RunesTeleportGodesConfig.RunaT7_RecipeString,
                RunesTeleportGodesConfig.RunaT7_AllowedItemsCSV,
                t7.PrefabName,
                t7.IconFileName,
                t7.VfxName,
                t7.SfxName,
                t7.NameCode,
                t7.DescriptionCode
            );
            Harmony harmony = new Harmony(RunesTeleportGodes.PluginGUID);
            harmony.PatchAll(typeof(Player_ConsumeRune_Patch));

            PrefabManager.OnVanillaPrefabsAvailable += AddExtraBossDrops;
        }

        private void RegisterRuna(
            AssetBundle assetBundle,
            string runaId,
            BepInEx.Configuration.ConfigEntry<float> cooldownCE,
            BepInEx.Configuration.ConfigEntry<float> weightCE,
            BepInEx.Configuration.ConfigEntry<bool> craftEnabledCE,
            BepInEx.Configuration.ConfigEntry<bool> bossDropEnabledCE,
            BepInEx.Configuration.ConfigEntry<string> bossPrefabCE,
            BepInEx.Configuration.ConfigEntry<float> bossDropChanceCE,
            BepInEx.Configuration.ConfigEntry<int> bossDropAmountCE,
            BepInEx.Configuration.ConfigEntry<string> craftStationCE,
            BepInEx.Configuration.ConfigEntry<int> minStationLevelCE,
            BepInEx.Configuration.ConfigEntry<string> recipeStringCE,
            BepInEx.Configuration.ConfigEntry<string> allowedItemsCSVCE,
            string prefabName,
            string iconFile,
            string vfxName,
            string sfxName,
            string nameCode,
            string descriptionCode
        )
        {
            GameObject runePrefab = assetBundle.LoadAsset<GameObject>(prefabName);
            if (runePrefab == null)
            {
                Logger.LogWarning($"No se encontró prefab '{prefabName}' para la runa {runaId}.");
                return;
            }
            if (runePrefab.GetComponent<ItemDrop>() == null)
            {
                Logger.LogError($"El prefab '{prefabName}' no tiene ItemDrop. Se aborta registro de {runaId}.");
                return;
            }
            GameObject vfxObj = null;
            if (!string.IsNullOrEmpty(vfxName))
            {
                vfxObj = assetBundle.LoadAsset<GameObject>($"{vfxName}.prefab");
                if (vfxObj != null && PrefabManager.Instance.GetPrefab(vfxName) == null)
                {
                    PrefabManager.Instance.AddPrefab(vfxObj);
                }
            }
            GameObject sfxObj = null;
            if (!string.IsNullOrEmpty(sfxName))
            {
                sfxObj = assetBundle.LoadAsset<GameObject>($"{sfxName}.prefab");
                if (sfxObj != null && PrefabManager.Instance.GetPrefab(sfxName) == null)
                {
                    PrefabManager.Instance.AddPrefab(sfxObj);
                }
            }

            var config = new RunaItemConfig(runaId, prefabName)
            {
                CooldownCE = cooldownCE,
                WeightCE = weightCE,
                CraftEnabledCE = craftEnabledCE,
                BossDropEnabledCE = bossDropEnabledCE,
                BossPrefabCE = bossPrefabCE,
                BossDropChanceCE = bossDropChanceCE,
                BossDropAmountCE = bossDropAmountCE,
                CraftStationCE = craftStationCE,
                MinStationLevelCE = minStationLevelCE,
                RecipeStringCE = recipeStringCE,
                AllowedItemsCSVCE = allowedItemsCSVCE,
                IconFileName = iconFile,
                VfxName = vfxName,
                SfxName = sfxName,
                VfxPrefab = vfxObj,
                SfxPrefab = sfxObj,
                NameCode = nameCode,
                DescriptionCode = descriptionCode
            };

            cooldownCE.SettingChanged += (s, e) => ReapplyRune(runaId);
            weightCE.SettingChanged += (s, e) => ReapplyRune(runaId);
            craftEnabledCE.SettingChanged += (s, e) => ReapplyRune(runaId);
            bossDropEnabledCE.SettingChanged += (s, e) => ReapplyRune(runaId);
            bossDropChanceCE.SettingChanged += (s, e) => ReapplyRune(runaId);
            bossDropAmountCE.SettingChanged += (s, e) => ReapplyRune(runaId);
            craftStationCE.SettingChanged += (s, e) => ReapplyRune(runaId);
            minStationLevelCE.SettingChanged += (s, e) => ReapplyRune(runaId);
            recipeStringCE.SettingChanged += (s, e) => ReapplyRune(runaId);
            allowedItemsCSVCE.SettingChanged += (s, e) => ReapplyRune(runaId);

            Sprite runeIcon = LoadIcon(assetBundle, iconFile);
            if (runeIcon == null)
            {
                Logger.LogWarning($"No se encontró ícono '{iconFile}' para runa {runaId}. Usando ícono por defecto.");
                runeIcon = RenderManager.Instance.Render(runePrefab, RenderManager.IsometricRotation);
            }

            var finalRecipe = ParseRecipeString(recipeStringCE.Value);

            var itemConfig = new ItemConfig
            {
                Name = $"${config.NameCode}",
                Description = $"${config.DescriptionCode}",
                Icon = runeIcon,
                CraftingStation = craftEnabledCE.Value ? craftStationCE.Value : null,
                MinStationLevel = craftEnabledCE.Value ? minStationLevelCE.Value : 0,
                Amount = 1
            };

            if (craftEnabledCE.Value)
            {
                foreach (var (mat, amt) in finalRecipe)
                {
                    itemConfig.AddRequirement(new RequirementConfig(mat, amt));
                }
            }

            var customItem = new CustomItem(runePrefab, fixReference: false, itemConfig);
            customItem.ItemDrop.m_itemData.m_shared.m_weight = weightCE.Value;
            customItem.ItemDrop.m_itemData.m_shared.m_itemType = ItemDrop.ItemData.ItemType.Consumable;
            ItemManager.Instance.AddItem(customItem);

            _runaConfigs[runaId] = config;
            Logger.LogInfo($"Registrada runa {runaId} (prefab '{prefabName}'), craft={craftEnabledCE.Value}, bossDrop={bossDropEnabledCE.Value}");
        }

        private void ReapplyRune(string runeId)
        {
            if (!_runaConfigs.TryGetValue(runeId, out var config)) return;

            Logger.LogInfo($"[ReapplyRune] Re-aplicando valores en caliente para {runeId}...");

            float newWeight = config.WeightCE.Value;
            bool newCraft = config.CraftEnabledCE.Value;
            string newRecipe = config.RecipeStringCE.Value;
            string station = newCraft ? config.CraftStationCE.Value : null;
            int stationLevel = newCraft ? config.MinStationLevelCE.Value : 0;

            var allObjects = Resources.FindObjectsOfTypeAll<GameObject>()
                .Where(obj => obj.name == config.PrefabName ||
                              obj.name.StartsWith($"{config.PrefabName}(Clone)", StringComparison.OrdinalIgnoreCase));
            foreach (var obj in allObjects)
            {
                var drop = obj.GetComponent<ItemDrop>();
                if (drop != null)
                {
                    drop.m_itemData.m_shared.m_weight = newWeight;
                    Logger.LogInfo($" => {obj.name}: Nuevo peso = {newWeight}");
                }
            }

            var finalRecipe = ParseRecipeString(newRecipe);
            var rcfg = new RecipeConfig
            {
                Item = config.PrefabName,  
                CraftingStation = station,
                MinStationLevel = stationLevel
            };
            foreach (var (mat, amt) in finalRecipe)
            {
                rcfg.AddRequirement(new RequirementConfig(mat, amt));
            }
            var newCustomRecipe = new CustomRecipe(rcfg);

            CustomRecipe curCrecipe = ItemManager.Instance.GetRecipe(config.PrefabName);
            if (curCrecipe != null && curCrecipe.Recipe != newCustomRecipe.Recipe && ObjectDB.instance != null)
            {

                var hashsetRecipes = AccessTools.Field(typeof(ItemManager), "Recipes").GetValue(ItemManager.Instance) as HashSet<CustomRecipe>;
                if (hashsetRecipes != null)
                {
                    hashsetRecipes.Remove(curCrecipe);
                    hashsetRecipes.Add(newCustomRecipe);
                }

                ObjectDB.instance.m_recipes.Remove(curCrecipe.Recipe);
                ObjectDB.instance.m_recipes.Add(newCustomRecipe.Recipe);

                int idx = ObjectDB.instance.m_recipes.IndexOf(newCustomRecipe.Recipe);
                if (idx != -1)
                {
                    ObjectDB.instance.m_recipes[idx].m_resources = newCustomRecipe.Recipe.m_resources;
                    foreach (var res in ObjectDB.instance.m_recipes[idx].m_resources)
                    {
                        var prefab = ObjectDB.instance.GetItemPrefab(res.m_resItem.name.Replace("JVLmock_", ""));
                        if (prefab != null)
                        {
                            res.m_resItem = prefab.GetComponent<ItemDrop>();
                        }
                    }
                    try
                    {
                        CraftingStation craftable_at = PrefabManager.Instance.GetPrefab(newCustomRecipe.Recipe.m_craftingStation.name.Replace("JVLmock_", ""))?.GetComponent<CraftingStation>();
                        ObjectDB.instance.m_recipes[idx].m_craftingStation = craftable_at;
                        ObjectDB.instance.m_recipes[idx].m_repairStation = craftable_at;
                        ObjectDB.instance.m_recipes[idx].m_item = PrefabManager.Instance.GetPrefab(config.PrefabName)?.GetComponent<ItemDrop>();
                    }
                    catch { }
                }
                Logger.LogInfo($"[ReapplyRune] Receta nueva para {config.PrefabName} actualizada en el ObjectDB con {finalRecipe.Count} requisitos.");
            }
            else if (newCraft)
            {
                if (ObjectDB.instance != null)
                {
                    ObjectDB.instance.m_recipes.Add(newCustomRecipe.Recipe);
                    Logger.LogInfo($"[ReapplyRune] Receta nueva para {config.PrefabName} agregada al ObjectDB con {finalRecipe.Count} requisitos.");
                }
                else
                {
                    Logger.LogWarning("[ReapplyRune] ObjectDB.instance es nulo. No se pudo agregar la receta.");
                }
            }
            else
            {
                Logger.LogInfo($" => Craft deshabilitado para {runeId}; no se registra receta.");
            }

            ReapplyBossDrop(config);
            Logger.LogInfo($"[ReapplyRune] {runeId} reaplicado con éxito.");
        }


        private void ReapplyBossDrop(RunaItemConfig config)
        {
            bool newBossDrop = config.BossDropEnabledCE.Value;
            float newChance = config.BossDropChanceCE.Value;
            int newAmt = config.BossDropAmountCE.Value;
            string bossPrefab = config.BossPrefabCE.Value;
            if (string.IsNullOrEmpty(bossPrefab)) return;
            var boss = PrefabManager.Instance.GetPrefab(bossPrefab);
            if (!boss)
            {
                Logger.LogWarning($"[ReapplyBossDrop] No se encontró boss prefab '{bossPrefab}' para {config.Id}");
                return;
            }
            var cdrop = boss.GetComponent<CharacterDrop>();
            if (cdrop == null)
            {
                Logger.LogWarning($"El boss '{bossPrefab}' no tiene CharacterDrop. No se añade/quita drop.");
                return;
            }
            cdrop.m_drops.RemoveAll(d => d.m_prefab && d.m_prefab.name == config.PrefabName);
            if (newBossDrop)
            {
                var runaPrefab = PrefabManager.Instance.GetPrefab(config.PrefabName);
                if (runaPrefab == null)
                {
                    Logger.LogWarning($"No se encontró prefab runa '{config.PrefabName}' para re-aplicar bossDrop.");
                    return;
                }
                var newDrop = new CharacterDrop.Drop
                {
                    m_prefab = runaPrefab,
                    m_amountMin = newAmt,
                    m_amountMax = newAmt,
                    m_chance = newChance,
                    m_levelMultiplier = false
                };
                cdrop.m_drops.Add(newDrop);
                Logger.LogInfo($" => BossDrop re-aplicado: {bossPrefab} dropea {config.PrefabName} x{newAmt} chance={newChance}");
            }
            else
            {
                Logger.LogInfo($" => BossDrop deshabilitado para {config.Id}.");
            }
        }

        private void AddExtraBossDrops()
        {
            foreach (var kvp in _runaConfigs)
            {
                ReapplyBossDrop(kvp.Value);
            }
        }

        private Sprite LoadIcon(AssetBundle bundle, string iconFileName)
        {
            if (string.IsNullOrEmpty(iconFileName)) return null;
            Texture2D tex = bundle.LoadAsset<Texture2D>(iconFileName);
            if (tex == null) return null;
            return Sprite.Create(tex, new Rect(0, 0, tex.width, tex.height), new Vector2(0.5f, 0.5f));
        }

        private List<(string mat, int amt)> ParseRecipeString(string recipeStr)
        {
            var result = new List<(string, int)>();
            if (string.IsNullOrEmpty(recipeStr)) return result;
            var pairs = recipeStr.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var pair in pairs)
            {
                var parts = pair.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length == 2)
                {
                    string mat = parts[0].Trim();
                    if (int.TryParse(parts[1].Trim(), out int amt))
                    {
                        result.Add((mat, amt));
                    }
                }
            }
            return result;
        }

        [HarmonyPatch(typeof(InventoryGui), nameof(InventoryGui.OnRightClickItem))]
        private static class Player_ConsumeRune_Patch
        {
            private static bool Prefix(InventoryGrid grid, ItemDrop.ItemData item)
            {
                if (grid.m_inventory != Player.m_localPlayer?.m_inventory) return true;
                if (item == null) return true;
                string prefabName = item.m_dropPrefab?.name;
                if (string.IsNullOrEmpty(prefabName)) return true;
                if (!RunesTeleportGodesItems._runaConfigs.TryGetValue(prefabName, out RunaItemConfig runaConfig))
                {
                    return true;
                }
                if (DateTime.Now < RunesTeleportGodesItems._globalNextUse)
                {
                    double remain = (RunesTeleportGodesItems._globalNextUse - DateTime.Now).TotalSeconds;
                    MessageHud.instance.ShowMessage(MessageHud.MessageType.Center, $"Aún en cooldown. Espera {remain:0.0}s");
                    return false;
                }
                var allowed = runaConfig.AllowedItemsCSVCE.Value
                    .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.Trim())
                    .ToList();
                if (!CheckTeleportable(allowed))
                {
                    MessageHud.instance.ShowMessage(MessageHud.MessageType.Center, "¡No puedes teletransportarte con algún ítem no permitido!");
                    return false;
                }
                float cooldownSec = runaConfig.CooldownCE.Value;
                RunesTeleportGodesItems._globalNextUse = DateTime.Now.AddSeconds(cooldownSec);
                grid.m_inventory.RemoveOneItem(item);
                if (runaConfig.VfxPrefab != null)
                {
                    Vector3 pos = Player.m_localPlayer.transform.position + Vector3.up;
                    UnityEngine.Object.Instantiate(runaConfig.VfxPrefab, pos, Quaternion.identity);
                }
                if (runaConfig.SfxPrefab != null)
                {
                    Vector3 pos = Player.m_localPlayer.transform.position + Vector3.up;
                    UnityEngine.Object.Instantiate(runaConfig.SfxPrefab, pos, Quaternion.identity);
                }
                PlayerTeleportation.Instance.StartCoroutine(TeleportSequence(3f, 6f));
                return false;
            }

            private static IEnumerator TeleportSequence(float sfxDuration, float vfxDuration)
            {
                yield return new WaitForSeconds(sfxDuration);
                float extraTime = vfxDuration - sfxDuration;
                if (extraTime > 0f)
                {
                    yield return new WaitForSeconds(extraTime);
                }
                var profile = Game.instance.GetPlayerProfile();
                if (profile != null && profile.HaveCustomSpawnPoint())
                {
                    Vector3 bedPos = profile.GetCustomSpawnPoint();
                    Player.m_localPlayer.TeleportTo(bedPos, Player.m_localPlayer.transform.rotation, distantTeleport: true);
                }
                else
                {
                    Game.instance.RequestRespawn(2f);
                }
            }

            private static bool CheckTeleportable(List<string> allowed)
            {
                var inv = Player.m_localPlayer.m_inventory;
                foreach (var it in inv.GetAllItems())
                {
                    if (!it.m_shared.m_teleportable)
                    {
                        string n = it.m_dropPrefab?.name ?? "";
                        if (!allowed.Contains(n))
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
        }

        internal class RunaItemConfig
        {
            public string Id;
            public string PrefabName;
            public BepInEx.Configuration.ConfigEntry<float> CooldownCE;
            public BepInEx.Configuration.ConfigEntry<float> WeightCE;
            public BepInEx.Configuration.ConfigEntry<bool> CraftEnabledCE;
            public BepInEx.Configuration.ConfigEntry<bool> BossDropEnabledCE;
            public BepInEx.Configuration.ConfigEntry<string> BossPrefabCE;
            public BepInEx.Configuration.ConfigEntry<float> BossDropChanceCE;
            public BepInEx.Configuration.ConfigEntry<int> BossDropAmountCE;
            public BepInEx.Configuration.ConfigEntry<string> CraftStationCE;
            public BepInEx.Configuration.ConfigEntry<int> MinStationLevelCE;
            public BepInEx.Configuration.ConfigEntry<string> RecipeStringCE;
            public BepInEx.Configuration.ConfigEntry<string> AllowedItemsCSVCE;
            public string IconFileName;
            public string VfxName;
            public string SfxName;
            public GameObject VfxPrefab;
            public GameObject SfxPrefab;
            public string NameCode;         
            public string DescriptionCode;  
            public RunaItemConfig(string id, string prefabName)
            {
                Id = id;
                PrefabName = prefabName;
            }
        }
    }

    internal class PlayerTeleportation : MonoBehaviour
    {
        private static PlayerTeleportation _instance;
        public static PlayerTeleportation Instance
        {
            get
            {
                if (_instance == null)
                {
                    GameObject obj = new GameObject("PlayerTeleportation");
                    _instance = obj.AddComponent<PlayerTeleportation>();
                    DontDestroyOnLoad(obj);
                }
                return _instance;
            }
        }
    }

    internal class RunaData
    {
        public string Id;
        public string PrefabName;
        public string VfxName;
        public string SfxName;
        public float CooldownSec;
        public float Weight;
        public bool CraftEnabled;
        public bool BossDropEnabled;
        public string BossPrefabName;
        public float BossDropChance;
        public int BossDropAmount;
        public string CraftStation;
        public int MinStationLevel;
        public string RecipeString;
        public string AllowedItemsCSV;
        public string IconFileName;
        public string NameCode;
        public string DescriptionCode;
    }
}
