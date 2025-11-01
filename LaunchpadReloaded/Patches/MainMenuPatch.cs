using HarmonyLib;
using LaunchpadReloaded.Features;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using Rewired.Platforms.Custom;

namespace LaunchpadReloaded.Patches
{
    [HarmonyPatch(typeof(MainMenuManager), nameof(MainMenuManager.Start))]
    public static class MainMenuPatch
    {
        
        public static void Postfix(MainMenuManager __instance)
        {
            SetPlayColor(__instance.playButton, true);
            SetInventoryColor(__instance.inventoryButton, true);
            SetShopColor(__instance.shopButton, true);
            SetNewsColor(__instance.newsButton, false);
            SetAccountColor(__instance.myAccountButton, false);
            SetButtonColor(__instance.accountCTAButton, true);
            SetButtonColor(__instance.accountStatsButton, true);
            SetSettingsColor(__instance.settingsButton, false);
            SetButtonColor(__instance.creditsButton, false);
            SetButtonColor(__instance.quitButton, false);
        }

        private static void SetPlayColor(PassiveButton Button, bool shine)
        {
            Button.activeSprites.GetComponent<SpriteRenderer>().color = Palette.AcceptedGreen;
            Button.inactiveSprites.GetComponent<SpriteRenderer>().color = Palette.ImpostorRoleRed;
            Button.activeSprites.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = LaunchpadAssets.PlayButtonIcon.LoadAsset();
            Button.activeTextColor = Palette.ImpostorRoleRed;
            Button.inactiveTextColor = Palette.AcceptedGreen;
            if (shine)
            {
                Button.activeSprites.transform.GetChild(1).GetComponent<SpriteRenderer>().color = Color.clear;
                Button.inactiveSprites.transform.GetChild(1).GetComponent<SpriteRenderer>().color = Color.clear;  
            }
           
        }
        
        private static void SetShopColor(PassiveButton Button, bool shine)
        {
            Button.activeSprites.GetComponent<SpriteRenderer>().color = Palette.AcceptedGreen;
            Button.inactiveSprites.GetComponent<SpriteRenderer>().color = Palette.ImpostorRoleRed;
            Button.activeSprites.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = LaunchpadAssets.ShopButtonIcon.LoadAsset();
            Button.activeTextColor = Palette.ImpostorRoleRed;
            Button.inactiveTextColor = Palette.AcceptedGreen;
            if (shine)
            {
                Button.activeSprites.transform.GetChild(1).GetComponent<SpriteRenderer>().color = Color.clear;
                Button.inactiveSprites.transform.GetChild(1).GetComponent<SpriteRenderer>().color = Color.clear;  
            }
           
        }
        
        private static void SetInventoryColor(PassiveButton Button, bool shine)
        {
            Button.activeSprites.GetComponent<SpriteRenderer>().color = Palette.AcceptedGreen;
            Button.inactiveSprites.GetComponent<SpriteRenderer>().color = Palette.ImpostorRoleRed;
            Button.activeSprites.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = LaunchpadAssets.InventoryButtonIcon.LoadAsset();
            Button.activeTextColor = Palette.ImpostorRoleRed;
            Button.inactiveTextColor = Palette.AcceptedGreen;
            if (shine)
            {
                Button.activeSprites.transform.GetChild(1).GetComponent<SpriteRenderer>().color = Color.clear;
                Button.inactiveSprites.transform.GetChild(1).GetComponent<SpriteRenderer>().color = Color.clear;  
            }
           
        }
        
        private static void SetSettingsColor(PassiveButton Button, bool shine)
        {
            Button.activeSprites.GetComponent<SpriteRenderer>().color = Palette.AcceptedGreen;
            Button.inactiveSprites.GetComponent<SpriteRenderer>().color = Palette.ImpostorRoleRed;
            Button.activeSprites.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = LaunchpadAssets.SettingsButtonIcon.LoadAsset();
            Button.activeTextColor = Palette.ImpostorRoleRed;
            Button.inactiveTextColor = Palette.AcceptedGreen;
            if (shine)
            {
                Button.activeSprites.transform.GetChild(1).GetComponent<SpriteRenderer>().color = Color.clear;
                Button.inactiveSprites.transform.GetChild(1).GetComponent<SpriteRenderer>().color = Color.clear;  
            }
           
        }
        
        private static void SetNewsColor(PassiveButton Button, bool shine)
        {
            Button.activeSprites.GetComponent<SpriteRenderer>().color = Palette.AcceptedGreen;
            Button.inactiveSprites.GetComponent<SpriteRenderer>().color = Palette.ImpostorRoleRed;
            Button.activeSprites.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = LaunchpadAssets.NewsButtonIcon.LoadAsset();
            Button.activeTextColor = Palette.ImpostorRoleRed;
            Button.inactiveTextColor = Palette.AcceptedGreen;
            if (shine)
            {
                Button.activeSprites.transform.GetChild(1).GetComponent<SpriteRenderer>().color = Color.clear;
                Button.inactiveSprites.transform.GetChild(1).GetComponent<SpriteRenderer>().color = Color.clear;  
            }
           
        }
        
        private static void SetAccountColor(PassiveButton Button, bool shine)
        {
            Button.activeSprites.GetComponent<SpriteRenderer>().color = Palette.AcceptedGreen;
            Button.inactiveSprites.GetComponent<SpriteRenderer>().color = Palette.ImpostorRoleRed;
            Button.activeSprites.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = LaunchpadAssets.AccountButtonIcon.LoadAsset();
            Button.activeTextColor = Palette.ImpostorRoleRed;
            Button.inactiveTextColor = Palette.AcceptedGreen;
            if (shine)
            {
                Button.activeSprites.transform.GetChild(1).GetComponent<SpriteRenderer>().color = Color.clear;
                Button.inactiveSprites.transform.GetChild(1).GetComponent<SpriteRenderer>().color = Color.clear;  
            }
           
        }
        
        private static void SetButtonColor(PassiveButton Button, bool shine)
        {
            Button.activeSprites.GetComponent<SpriteRenderer>().color = Palette.AcceptedGreen;
            Button.inactiveSprites.GetComponent<SpriteRenderer>().color = Palette.ImpostorRoleRed;
            Button.activeTextColor = Palette.ImpostorRoleRed;
            Button.inactiveTextColor = Palette.AcceptedGreen;
            if (shine)
            {
                Button.activeSprites.transform.GetChild(1).GetComponent<SpriteRenderer>().color = Color.clear;
                Button.inactiveSprites.transform.GetChild(1).GetComponent<SpriteRenderer>().color = Color.clear;  
            }
           
        }
    }
}