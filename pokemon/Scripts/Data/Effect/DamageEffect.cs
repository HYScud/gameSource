using UnityEngine;

public class DamageEffect : EffectBase
{
    public override void ApplyEffect(BattleContext battleContext)
    {
        //伤害 = (((((2 × 等级) ÷ 5 + 2) × 威力 × 攻击方攻击力/特攻力 ÷ 防御方防御力/特防力) ÷ 50) + 2) × 修正系数
        var sourcePower = GetAttackerPower(battleContext);
        var targetDef = GetTargetDef(battleContext);

        var allModify = battleContext.BattlePowerModifyData.GetAllModify();

        var damage = sourcePower / targetDef / 50 + 2;
        var finalDamage = allModify * damage;
        battleContext.Target.TakeDamage(finalDamage);
    }

    public float GetAttackerPower(BattleContext battleContext)
    {
        //(2 × 等级) ÷ 5 + 2) × 威力 × 攻击方攻击力
        var atk = GetSourceAtk(battleContext);
        var tempBase = 2 * battleContext.Source.pokemon.level / 5 + 2;
        var movePower = battleContext.CurUsedMove.GetMovePower() * battleContext.MovePowerMultiplier;
        var sourcePower = tempBase * movePower * atk;
        return sourcePower;
    }

    public float GetSourceAtk(BattleContext battleContext)
    {
        //攻击方攻击力
        var level = battleContext.Source.pokemon.level;
        float atk = 0;
        if (battleContext.CurUsedMove.GetMoveType() == MoveTypeEnum.PhysicalMove)
        {
            atk = battleContext.Source.pokemon.attack * battleContext.BattleBaseValueModify.SourceBaseValueModify[0];
            atk *= BattleTools.GetStatValue(StatEnum.StatAtk,
                battleContext.BattleBaseValueModify.SourceBaseStatsModify[0]);
        }
        else
        {
            atk = battleContext.Source.pokemon.attack * battleContext.BattleBaseValueModify.SourceBaseValueModify[2];
            atk *= BattleTools.GetStatValue(StatEnum.StatSpAtk,
                battleContext.BattleBaseValueModify.SourceBaseStatsModify[2]);
        }

        return atk;
    }

    public float GetTargetDef(BattleContext battleContext)
    {
        //(2 × 等级) ÷ 5 + 2) × 威力 × 攻击方攻击力
        float def = 0;
        if (battleContext.CurUsedMove.GetMoveType() == MoveTypeEnum.PhysicalMove)
        {
            def = battleContext.Source.pokemon.attack * battleContext.BattleBaseValueModify.SourceBaseValueModify[1];
            def *= BattleTools.GetStatValue(StatEnum.StatDef,
                battleContext.BattleBaseValueModify.SourceBaseStatsModify[1]);
        }
        else
        {
            def = battleContext.Source.pokemon.attack * battleContext.BattleBaseValueModify.SourceBaseValueModify[3];
            def *= BattleTools.GetStatValue(StatEnum.StatSpDef,
                battleContext.BattleBaseValueModify.SourceBaseStatsModify[3]);
        }

        return def;
    }
}