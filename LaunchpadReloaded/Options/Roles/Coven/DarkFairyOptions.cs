using LaunchpadReloaded.Roles.Coven;
using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Utilities;

namespace LaunchpadReloaded.Options.Roles.Coven;

public class DarkFairyOptions : AbstractOptionGroup<DarkFairyRole>
{
    public override string GroupName => "Dark Fairy";
    [ModdedNumberOption("Darken Cooldown", 0, 60, 5, MiraNumberSuffixes.Seconds)]
    public float DarkenCooldown { get; set; } = 20;

    [ModdedNumberOption("Max Darken Uses", 0, 10, zeroInfinity:true)]
    public float DarkenUses { get; set; } = 3;
}