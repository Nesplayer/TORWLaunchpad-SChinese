using MiraAPI.GameOptions;
using MiraAPI.Roles;
using UnityEngine;

namespace LaunchpadReloaded.Roles.Crewmate
{
    public interface ICrewmateRole : ICustomRole, IOptionable
    {
        ModdedRoleTeams ICustomRole.Team => ModdedRoleTeams.Crewmate;

        RoleOptionsGroup ICustomRole.RoleOptionsGroup => 
            new RoleOptionsGroup("♦ Crewmate Roles ♦", new Color32(120, 204, 236, byte.MaxValue), 0);

        TeamIntroConfiguration? ICustomRole.IntroConfiguration => 
            new TeamIntroConfiguration(Color.cyan, "CREWMATE", 
                "You are a Crewmate. Do tasks and vote off the " + 
                Extensions.ToTextColor(Palette.ImpostorRed) + "Impostor</color>.");
    }
}