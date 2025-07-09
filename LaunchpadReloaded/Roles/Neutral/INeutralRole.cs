using MiraAPI.GameOptions;
using MiraAPI.Roles;
using UnityEngine;

namespace LaunchpadReloaded.Roles.Neutral
{
    public interface INeutralRole : ICustomRole, IOptionable
    {
        ModdedRoleTeams ICustomRole.Team => ModdedRoleTeams.Custom;

        RoleOptionsGroup ICustomRole.RoleOptionsGroup =>
            new RoleOptionsGroup("♦ Neutral Roles ♦", Color.gray, 0);

        TeamIntroConfiguration? ICustomRole.IntroConfiguration =>
            new TeamIntroConfiguration(Color.gray, "NEUTRAL", 
                "You are a Neutral. You do not have a team.");
    }
}