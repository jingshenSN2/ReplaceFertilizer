using StardewModdingAPI;

namespace JingshenSN2.ReplaceFertilizer.Patches
{
    internal class Patch
    {
        internal static IMonitor? Monitor;

        public Patch(IMonitor monitor)
        {
            Monitor = monitor;
        }
    }
}