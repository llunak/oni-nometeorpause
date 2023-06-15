using HarmonyLib;
using System.Collections;

namespace NoMeteorPause
{
    [HarmonyPatch(typeof(SaveUpgradeWarning))]
    public class SaveUpgradeWarning_Patch
    {
        private static IEnumerator MakeEmptyEnumerator()
        {
            yield break;
        }

        [HarmonyPrefix]
        [HarmonyPatch(nameof(TemporaryDisableMeteorShowers))]
        public static bool TemporaryDisableMeteorShowers(ref IEnumerator __result)
        {
            __result = MakeEmptyEnumerator();
            return false;
        }
    }
}
