using MiraAPI.Modifiers;
using MiraAPI.Utilities.Assets;
using LaunchpadReloaded.Components;
using LaunchpadReloaded.Features;
using LaunchpadReloaded.Utilities;
using UnityEngine;

namespace LaunchpadReloaded.Modifiers;

public class SilencedModifier : BaseModifier
{
    public override string ModifierName => "Silenced";
    public override LoadableAsset<Sprite>? ModifierIcon => LaunchpadAssets.Silenced;
    public override string GetDescription() => $"You have been <b>silenced</b>! This means you're unable to send messages in chat until the meeting ends.";
    
    private readonly PlayerTag _silencedTag = new()
        {
            Name = "SilencedTag",
            Text = "Silenced",
            Color = LaunchpadPalette.SilencerColor,
            IsLocallyVisible = _ => true,
        };

    public override void OnActivate()
    {
        var tagManager = Player!.GetTagManager();

        if (tagManager != null)
        {
            var existingTag = tagManager.GetTagByName(_silencedTag.Name);
            if (existingTag.HasValue)
            {
                tagManager.RemoveTag(existingTag.Value);
            }

            tagManager.AddTag(_silencedTag);
        }
    }
    
    public override void OnDeactivate()
    {
        var tagManager = Player?.GetTagManager();

        if (tagManager != null)
        {
            tagManager.RemoveTag(_silencedTag);
        }
    }
    
    public override void OnDeath(DeathReason reason)
        {
            ModifierComponent!.RemoveModifier(this);
        }
}