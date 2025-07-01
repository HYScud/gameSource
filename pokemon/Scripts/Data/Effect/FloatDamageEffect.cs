public class FloatDamageEffect : EffectBase
{
    public override void ApplyEffect(BattleContext battleContext)
    {
        var damage = GetMovePower(battleContext);
        var finalDamage = damage * battleContext.BattlePowerModifyData.TypeModify;
        battleContext.Target.TakeDamage(finalDamage);
    }

    public float GetMovePower(BattleContext battleContext)
    {
        float power = 0;
        switch (battleContext.CurUsedMove.GetMovePowerType())
        {
            case MovePowerTypeEnum.Fixed:
                power = battleContext.CurUsedMove.GetMovePower();
                break;
            case MovePowerTypeEnum.Level:
                power = battleContext.Source.pokemon.level;
                break;
            case MovePowerTypeEnum.MaxHp:
                power = battleContext.Target.pokemon.maxHp;
                break;
            case MovePowerTypeEnum.PercentCurHp:
                power = battleContext.Target.pokemon.curHp * battleContext.CurUsedMove.GetMovePower();
                break;
            case MovePowerTypeEnum.PercentMaxHp:
                power = battleContext.Target.pokemon.maxHp * battleContext.CurUsedMove.GetMovePower();
                break;
            case MovePowerTypeEnum.Friendship:
                power = battleContext.Source.pokemon.BasePointsFriendship / 2.5f;
                break;
        }

        return power;
    }
}