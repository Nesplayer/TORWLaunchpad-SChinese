using LaunchpadReloaded.Options.Modifiers;
using MiraAPI.Events;
using MiraAPI.Events.Vanilla.Gameplay;
using MiraAPI.GameOptions;
using MiraAPI.Modifiers;
using MiraAPI.Modifiers.Types;

namespace LaunchpadReloaded.Modifiers;

public class BaitModifier : GameModifier
{
    public override string ModifierName => "Bait";

    public override int GetAmountPerGame()
    {
        return (int)OptionGroupSingleton<BaitModifierOptions>.Instance.Amount;
    }

    public override int GetAssignmentChance()
    {
        return (int)OptionGroupSingleton<BaitModifierOptions>.Instance.BaitChance;
    }

    public override string GetDescription()
    {
        return "Your killer self-reports after you are killed!";
    }

    [RegisterEvent]
    public static void OnKill(AfterMurderEvent e)
    {
        if (ModifierExtensions.HasModifier<BaitModifier>(e.Target))
        {
            e.Source.CmdReportDeadBody(e.Target.Data);
        }
    }
}