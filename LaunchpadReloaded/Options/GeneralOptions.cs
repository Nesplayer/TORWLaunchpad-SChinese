using MiraAPI.GameModes;
using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using System;
using LaunchpadReloaded.Features;
using MiraAPI.GameOptions.OptionTypes;
using UnityEngine;

namespace LaunchpadReloaded.Options;

public class GeneralOptions : AbstractOptionGroup
{
    public override string GroupName => "General";
    public override Color GroupColor => LaunchpadPalette.GeneralMenu;
    public override Func<bool> GroupVisible => CustomGameModeManager.IsDefault;

    public ModdedToggleOption Notepad { get; set; } = new("Notepad", true)
    {
        ChangedEvent = value =>
        {
            NotepadHud.Instance?.SetNotepadButtonVisible(value);
        }
    };

    [ModdedToggleOption("Ban Cheaters")] public bool BanCheaters { get; set; } = true;
    [ModdedToggleOption("Disable Meeting Teleport")] public bool DisableMeetingTeleport { get; set; } = false;

}