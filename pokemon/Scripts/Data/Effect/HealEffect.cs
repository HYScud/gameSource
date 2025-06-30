using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealEffect : EffectBase
{
    public bool isPercentage { get; set; }
    public float value { get; set; }

    public HealEffect(bool isPercentage, float value)
    {
        this.isPercentage = isPercentage;
        this.value = value;
    }

    public override void ApplyEffect(BattleContext battleContext)
    {
        if (battleContext?.Target != null)
        {
            //TODO:发送事件（处理回血）      
        }
    }
}