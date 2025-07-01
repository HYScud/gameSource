public enum ConditionEnum
{
    BattleStart,
    BeforeUseMove,
    BeforeCalculateDamage, //计算伤害前，获取相关计算所需的修改量
    AfterUseMove,
    OnMoveApply,
    OnHurt,
    AfterCalculateDamage,
    RoundEnd,
    BattleEnd,
    HpChange
}