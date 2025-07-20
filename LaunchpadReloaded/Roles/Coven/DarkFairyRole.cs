using LaunchpadReloaded.Options.Roles.Coven;
using LaunchpadReloaded.Features;
using Il2CppSystem.Text;
using MiraAPI.GameOptions;
using MiraAPI.Roles;
using UnityEngine;

namespace LaunchpadReloaded.Roles.Coven;

public class DarkFairyRole(System.IntPtr ptr) : RoleBehaviour(ptr), ICovenRole
{
    public string RoleName => "Dark Fairy";
    public string RoleDescription => "Use magic against the crew.";
    public string RoleLongDescription => "Use your role block ability to\nstop players from using their ability";
    public Color RoleColor => LaunchpadPalette.DarkFairyColor;
    public override bool IsDead => false;

    public CustomRoleConfiguration Configuration => new CustomRoleConfiguration(this)
    {
        CanGetKilled = true,
        Icon = LaunchpadAssets.Darken,
    };

    public override void AppendTaskHint(StringBuilder taskStringBuilder)
    {
        // remove default task hint
    }
    
    public override void SpawnTaskHeader(PlayerControl playerControl)
    {
        playerControl.SpawnCovenTaskHeader();
    }
}