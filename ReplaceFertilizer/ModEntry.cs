using HarmonyLib;
using JingshenSN2.ReplaceFertilizer.Patches;
using StardewModdingAPI;

namespace JingshenSN2.ReplaceFertilizer
{
    internal sealed class ModEntry : Mod
    {
        private Harmony? _harmony;
        public static ModEntry? _instance;
        public override void Entry(IModHelper helper)
        {
            _instance = this;
            ApplyPatch();
        }

        public void Info(string message)
        {
            Monitor.Log(message, LogLevel.Info);
        }

        private void ApplyPatch()
        {
            _harmony = new Harmony(ModManifest.UniqueID);
            new HoeDirtPatch(Monitor).Apply(_harmony);
        }
    }
}