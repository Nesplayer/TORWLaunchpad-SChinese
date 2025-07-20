using LaunchpadReloaded.Components;
using LaunchpadReloaded.Features;
using LaunchpadReloaded.Utilities;
using MiraAPI.Modifiers;
using System.Linq;
using UnityEngine;

namespace LaunchpadReloaded.Modifiers;

public class DarkenModifier : BaseModifier
{
    public override string ModifierName => "Darkened";
    private readonly int _visorColor = Shader.PropertyToID("_VisorColor");
    private Color _ogVisorColor;

    private static readonly PlayerTag _darkenedTag = new()
    {
        Name = "DarkenedTag",
        Text = "Darkened",
        Color = LaunchpadPalette.DarkenedColor,
        IsLocallyVisible = _ => true,
    };

    public override void OnActivate()
    {
        var tagManager = Player!.GetTagManager();
        if (tagManager == null) return;

        // Remove old tag with same name if present
        var existingTag = tagManager.GetTagByName(_darkenedTag.Name);
        if (existingTag.HasValue)
        {
            tagManager.RemoveTag(existingTag.Value);
        }

        // Add the new tag
        tagManager.AddTag(_darkenedTag);

        // Change visor color
        _ogVisorColor = Player.cosmetics.currentBodySprite.BodySprite.material.GetColor(_visorColor);
        Player.cosmetics.currentBodySprite.BodySprite.material.SetColor(_visorColor, LaunchpadPalette.DarkenedColor);
    }

    public override void OnDeactivate()
    {
        var tagManager = Player?.GetTagManager();
        if (tagManager != null)
        {
            tagManager.RemoveTag(_darkenedTag);
        }

        Player!.cosmetics.currentBodySprite.BodySprite.material.SetColor(_visorColor, _ogVisorColor);
    }

    public override void OnDeath(DeathReason reason)
    {
        ModifierComponent?.RemoveModifier(this);
    }

    public override void FixedUpdate()
    {
        if (MeetingHud.Instance)
        {
            var playerState = MeetingHud.Instance.playerStates.FirstOrDefault(plr => plr.TargetPlayerId == Player!.PlayerId);
            if (playerState != null)
            {
                playerState.PlayerIcon.cosmetics.currentBodySprite.BodySprite.material.SetColor(_visorColor, LaunchpadPalette.DarkenedColor);
            }
        }
    }
}