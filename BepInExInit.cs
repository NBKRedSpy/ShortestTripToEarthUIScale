using BepInEx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using BepInEx.Harmony;
//using Harmony;
using HarmonyLib;

namespace StteUiScale
{
    
    [BepInPlugin("A3B7094F-0267-401A-A917-E3EDA3EF7C5C", "StteUiScale","1.0.0.0")]
    class BepInExInit : BaseUnityPlugin
    {
        public void Awake()
        {
            var harmony = HarmonyWrapper.PatchAll("com.github.NBKRedSpy.StteUiScale");

            //The patch doesn't seem to take with the Wrapper version of the patch.  
            //  However, invoking the PatchAll on the instance does.
            harmony.PatchAll();
        }
    }
}
