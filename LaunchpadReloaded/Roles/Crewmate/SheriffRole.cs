using LaunchpadReloaded.Features;
using MiraAPI.Roles;
using System;
using UnityEngine;
using LaunchpadReloaded.Translations;

namespace LaunchpadReloaded.Roles.Crewmate;

public class SheriffRole(IntPtr ptr) : CrewmateRole(ptr), ICustomRole
{
    public string RoleName => Rolename.GetTranslatedText(); 
    public TranslationPool Rolename = new TranslationPool(
        english: "Sheriff",
        spanish: "Alguacil",
        french: "Shérif"
    );
    public string RoleDescription => RoleDescShort.GetTranslatedText();
    public TranslationPool RoleDescShort = new TranslationPool(
        english: "Take your chance by shooting a player.",
        french: "Prenez votre chance en tirant un joueur.",
        spanish: "Aprovecha tu oportunidad disparando a un jugador."
    );
    public string RoleLongDescription => RoleDescLong.GetTranslatedText();
    public TranslationPool RoleDescLong = new TranslationPool(
        english: $"You can shoot players, if you shoot an {Palette.ImpostorRed.ToTextColor()}Impostor</color> you will kill him\nbut if you shoot a {Palette.CrewmateBlue.ToTextColor()}Crewmate</color>, you will die with him.",
        spanish: $"Puedes disparar a los jugadores, si disparas a un {Palette.ImpostorRed.ToTextColor()}Impostor</color> lo matarás\npero si disparas a un {Palette.CrewmateBlue.ToTextColor()}Tripulante</color>, morirás junto a él.",
        french: $"Vous pouvez tirer sur les joueurs, si vous tirez sur un {Palette.ImpostorRed.ToTextColor()}Imposteur</color> vous le tuerez\nmais si vous tirez sur un {Palette.CrewmateBlue.ToTextColor()}Équipier</color>, vous mourrez avec lui."
    );
    public Color RoleColor => LaunchpadPalette.SheriffColor;
    public ModdedRoleTeams Team => ModdedRoleTeams.Crewmate;

    public CustomRoleConfiguration Configuration => new(this)
    {
        Icon = LaunchpadAssets.ShootButton,
        OptionsScreenshot = LaunchpadAssets.SheriffBanner,
    };
}
