using System.Collections.Generic;
using UnityEngine;

public struct EffectData
{
    public ConditionData Condition;
    public EffectBase Effect;

    public EffectData(ConditionData condition, EffectBase effect)
    {
        Condition = condition;
        Effect = effect;
    }
}

public abstract class EffectObjectBase
{
    protected List<EffectData> EffectDataList;

    protected virtual void AddEffectToList(EffectData effectData)
    {
        EffectDataList.Add(effectData);
    }

    public virtual void ApplyEffects(BattleContext battleContext)
    {
        EffectDataList.ForEach(effectData =>
        {
            var canApplyEffect = ConditionTool.CheckCondition(battleContext, effectData.Condition);
            if (canApplyEffect)
                effectData.Effect?.ApplyEffect(battleContext);
            else
                Debug.Log("Effect Apply Error. Condition is not met");
        });
    }
}