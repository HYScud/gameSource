using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item : EffectObjectBase
{
    public string Id;
    public string OriginId;
    public string Desc;
    public string ItemName;

    protected Item(string id, string originId, string desc, string itemName, ConditionData condition)
    {
        Id = id;
        OriginId = originId;
        Desc = desc;
        ItemName = itemName;
        Condition = condition;
        EffectList = new List<EffectBase>();
    }
}