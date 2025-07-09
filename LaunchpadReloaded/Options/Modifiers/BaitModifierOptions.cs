using LaunchpadReloaded.Features;
using LaunchpadReloaded.Modifiers;
using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using UnityEngine;
using MiraAPI.Utilities;

namespace LaunchpadReloaded.Options.Modifiers
{
	public class BaitModifierOptions : AbstractOptionGroup<BaitModifier>
	{
		public override string GroupName => "Bait Options";
		public override Color GroupColor => LaunchpadPalette.BaitMenu;

		[ModdedNumberOption("Amount", 0f, 5f, 1f, suffixType: MiraNumberSuffixes.None, zeroInfinity: true)]
		public float Amount { get; set; } = 1f;

		[ModdedNumberOption("Bait Chance", 0f, 100f, 10f, suffixType: MiraNumberSuffixes.Percent)]
		public float BaitChance { get; set; } = 0f;
	}
}
