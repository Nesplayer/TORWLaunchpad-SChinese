using AmongUs.GameOptions;
using Il2CppSystem.Text;
using LaunchpadReloaded.Features;
using LaunchpadReloaded.Options.Roles.Neutral;
using MiraAPI.GameOptions;
using MiraAPI.Roles;
using UnityEngine;

namespace LaunchpadReloaded.Roles.Neutral;

public class NeutralKillerRole(System.IntPtr ptr) : RoleBehaviour(ptr), INeutralRole
{
    public string RoleName => "Neutral Killer";

    public string RoleDescription => "Neutral who can kill.\nThis is just a template role, it does nothing at this point, but will in the future.";

    public string RoleLongDescription => "This is just a template role, it does nothing at this point, but will in the future.";

    public Color RoleColor => LaunchpadPalette.NeutralKillerColor;

    public override bool IsDead => false;

    public CustomRoleConfiguration Configuration => new(this)
    {
        TasksCountForProgress = false,
        CanUseVent = OptionGroupSingleton<JesterOptions>.Instance.CanUseVents,
        GhostRole = (RoleTypes)RoleId.Get<OutcastGhostRole>(),
        Icon = LaunchpadAssets.JesterIcon,
        OptionsScreenshot = LaunchpadAssets.JesterBanner,
    };

    public override void AppendTaskHint(StringBuilder taskStringBuilder)
    {
        // No task hints
    }

    public override bool DidWin(GameOverReason reason)
    {
        return GameManager.Instance.DidHumansWin(reason);
    }
}