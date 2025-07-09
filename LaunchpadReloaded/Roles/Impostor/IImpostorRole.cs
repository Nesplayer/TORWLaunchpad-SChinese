using MiraAPI.GameOptions;
using MiraAPI.Roles;
using UnityEngine;

namespace LaunchpadReloaded.Roles.Impostor
{
    public interface IImpostorRole : ICustomRole, IOptionable
    {
        ModdedRoleTeams ICustomRole.Team => ModdedRoleTeams.Impostor;

        RoleOptionsGroup ICustomRole.RoleOptionsGroup =>
            new RoleOptionsGroup("♦ Impostor Roles ♦", new Color32(203, 83, 84, byte.MaxValue), 0);

        TeamIntroConfiguration? ICustomRole.IntroConfiguration =>
            new TeamIntroConfiguration(Color.red, "IMPOSTOR", 
                "You are an Impostor. Sabotage and kill the crew.");
    }
}