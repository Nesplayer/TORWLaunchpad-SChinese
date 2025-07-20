using LaunchpadReloaded.Options.Roles.Coven;
using LaunchpadReloaded.Features;
using Il2CppSystem.Text;
using MiraAPI.GameOptions;
using MiraAPI.Roles;
using UnityEngine;

namespace LaunchpadReloaded.Roles.Coven;

public class TavernKeeperRole(System.IntPtr ptr) : RoleBehaviour(ptr), ICovenRole
{
    public string RoleName => "Tavern Keeper";
    public string RoleDescription => "Use magic against the crew.";
    public string RoleLongDescription => "Use your role block ability to\nstop players from using their ability";
    public Color RoleColor => LaunchpadPalette.TavernKeeperColor;
    public override bool IsDead => false;

    public CustomRoleConfiguration Configuration => new CustomRoleConfiguration(this)
    {
        CanGetKilled = true,
        Icon = LaunchpadAssets.RoleBlockButton,
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