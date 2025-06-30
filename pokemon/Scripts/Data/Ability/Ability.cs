using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Ability : EffectObjectBase
{
    public string Id;
    public string OriginId;
    public string AbilityName;
    public string Desc;

    protected Ability(string id, string originId, string desc, string abilityName, ConditionData condition)
    {
        Id = id;
        OriginId = originId;
        Desc = desc;
        AbilityName = abilityName;
        Condition = condition;
        EffectList = new List<EffectBase>();
    }
}