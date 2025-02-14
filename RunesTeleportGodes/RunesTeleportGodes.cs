using BepInEx;
using BepInEx.Configuration;
using Jotunn;
using Jotunn.Entities;
using Jotunn.Managers;
using Jotunn.Utils;
using System.IO;
using System.Text.RegularExpressions;
using UnityEngine;
using Logger = Jotunn.Logger;
using HarmonyLib;
using System.Linq;

namespace RunesTeleportGodes
{
    [BepInPlugin(PluginGUID, PluginName, PluginVersion)]
    [BepInDependency(Main.ModGuid)]
    [NetworkCompatibility(CompatibilityLevel.EveryoneMustHaveMod, VersionStrictness.Minor)]
    public class RunesTeleportGodes : BaseUnityPlugin
    {
        public const string PluginGUID = "Azathoth18.RunesTeleportGodes";
        public const string PluginName = "RunesTeleportGodes";
        public const string PluginVersion = "0.0.1";

        internal static AssetBundle EmbeddedResourceBundle;
        private CustomLocalization _localization;

        private void Awake()
        {
            RunesTeleportGodesConfig.Initialize(Config);

            LoadAssets();
            AddLocalizations();

            new RunesTeleportGodesItems(EmbeddedResourceBundle);
        }

        private void LoadAssets()
        {
            EmbeddedResourceBundle = AssetUtils.LoadAssetBundleFromResources(
                "RunesTeleportGodes.AssetsEmbedded.runesteleportgodes",
                typeof(RunesTeleportGodes).Assembly
            );

            if (EmbeddedResourceBundle == null)
            {
                Logger.LogError("Failed to load the main AssetBundle: runesteleportgodes");
                return;
            }

            if (RunesTeleportGodesConfig.EnableDebugMode.Value)
            {
                Logger.LogInfo($"Main Asset Names: {string.Join(",", EmbeddedResourceBundle.GetAllAssetNames())}");
            }
        }
        private void AddLocalizations()
        {
            _localization = LocalizationManager.Instance.GetLocalization();

            foreach (string resource in typeof(RunesTeleportGodes).Assembly.GetManifestResourceNames())
            {
                if (!resource.Contains("localizations")) continue;

                Logger.LogInfo($"Loading localization: {resource}");
                string jsonContent = ReadEmbeddedResourceFile(resource);

                if (string.IsNullOrWhiteSpace(jsonContent))
                {
                    Logger.LogWarning($"Localization file {resource} is empty or could not be read.");
                    continue;
                }

                // Remove comments and clean the JSON string
                string cleanedLocalization = Regex.Replace(jsonContent, @"\/\/.*", "");
                var splitted = resource.Split('.');
                string locName = splitted[splitted.Length - 2];

                Logger.LogInfo($"Adding localization for language: '{locName}'");
                _localization.AddJsonFile(locName, cleanedLocalization);
            }
        }

        private string ReadEmbeddedResourceFile(string filename)
        {
            using (var stream = typeof(RunesTeleportGodes).Assembly.GetManifestResourceStream(filename))
            {
                if (stream == null)
                {
                    Logger.LogWarning($"No se encontró recurso incrustado: {filename}");
                    return "";
                }

                using (var reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
        }

        private void OnDestroy()
        {
            if (EmbeddedResourceBundle != null)
            {
                EmbeddedResourceBundle.Unload(false);
                EmbeddedResourceBundle = null;
            }
        }
    }
}
