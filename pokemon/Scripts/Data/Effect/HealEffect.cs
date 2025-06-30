using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealEffect : EffectBase
{
    public bool isPercentage { get; set; }

    public HealEffect(bool isPercentage)
    {
        this.isPercentage = isPercentage;
    }

    public override void ApplyEffect(BattleContext battleContext)
    {
        if (battleContext?.Target != null)
        {
            //TODO:发送事件（处理回血）      
        }
    }
}