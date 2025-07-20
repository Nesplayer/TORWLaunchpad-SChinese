using LaunchpadReloaded.Roles.Coven;
using LaunchpadReloaded.Features;
using LaunchpadReloaded.Modifiers;
using LaunchpadReloaded.Options.Roles.Coven;
using MiraAPI.GameOptions;
using MiraAPI.Modifiers;
using UnityEngine;
using MiraAPI.Utilities.Assets;
using MiraAPI.Utilities;

namespace LaunchpadReloaded.Buttons.Coven;
public class DarkenButton : BaseLaunchpadButton<PlayerControl>
{

    public override string Name => "Darken";
    public override float Cooldown => OptionGroupSingleton<DarkFairyOptions>.Instance.DarkenCooldown;
    public override float EffectDuration => 0;
    public override int MaxUses => (int)OptionGroupSingleton<DarkFairyOptions>.Instance.DarkenUses;
    public override LoadableAsset<Sprite> Sprite => LaunchpadAssets.Darken;
    public override bool TimerAffectedByPlayer => true;
    public override bool AffectedByHack => true;

    public override bool Enabled(RoleBehaviour? role)
    {
        return role is DarkFairyRole;
    }

    public override PlayerControl? GetTarget()
    {
        return PlayerControl.LocalPlayer.GetClosestPlayer(true, Distance, false);
    }

    public override void SetOutline(bool active)
    {
        Target?.cosmetics.SetOutline(active, new Il2CppSystem.Nullable<Color>(Palette.ImpostorRed));
    }

    public override bool IsTargetValid(PlayerControl? target)
    {
        return true;
    }
    protected override void OnClick()
    {
        if (Target != null)
        {
            Target.AddModifier<DarkenModifier>();
        }
    }

    public override void OnEffectEnd()
    {
    }
}