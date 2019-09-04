using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using BepInEx.Harmony;
using HarmonyLib;

namespace StteUiScale
{
    [HarmonyPatch(typeof(RST.Settings))]
    [HarmonyPatch( "UiScale",MethodType.Getter)]
    public class MainPatch
    {

        /// <summary>
        /// Hard does the UIScale, which is the computed value from the settings.
        /// The UI depends only on this property.
        /// </summary>
        /// <param name="__result"></param>
        /// <returns></returns>
        public static bool Prefix(ref float __result)
        {
            __result = 1.25f;
            return false;
        }
    }
}
