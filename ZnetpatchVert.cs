using HarmonyLib;
using UnityEngine;

namespace Vert2;

public class ZnetpatchVert
{
    [HarmonyPatch(typeof(ZNetScene), nameof(ZNetScene.Awake))]
    static class Vertclasspatch
    {
        static void Postfix(ZNetScene __instance)
        {
            if (__instance == null)
            {
                return;
            }
            
            GameObject sword = __instance.GetPrefab("SwordBronze");
                if (sword == null)
                {
                return;
                }

                var swordscript = sword.GetComponent<ItemDrop>();
                    if (swordscript != null)
                    {
                        swordscript.m_itemData.m_shared.m_name = "VertTinySword";
                    }
        
        }
    } 
}