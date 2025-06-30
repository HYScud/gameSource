using System.Collections.Generic;

public abstract class EffectObjectBase
{
    public ConditionData Condition;
    public List<EffectBase> EffectList;

    public virtual void AddEffectToList(EffectBase effectBase)
    {
        EffectList.Add(effectBase);
    }

    public virtual void ApplyEffects(BattleContext battleContext)
    {
        EffectList.ForEach(effect => { effect.ApplyEffect(battleContext); });
    }
}