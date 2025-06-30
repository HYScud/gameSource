using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StatModifierEffect : EffectBase
{
    private StatEnum m_EffectStat;
    private int m_Value;

    public StatEnum effectStat
    {
        get => m_EffectStat;
        set => m_EffectStat = value;
    }

    public int value
    {
        get => m_Value;
        set => m_Value = value;
    }

    private void ApplyEffect(BattlePokemon target)
    {
        switch (m_EffectStat)
        {
            case StatEnum.StatAtk:
            case StatEnum.StatDef:
            case StatEnum.StatSpAtk:
            case StatEnum.StatSpDef:
            case StatEnum.StatSpeed:
                target.normalStatLevel[(int)m_EffectStat - 1] = m_Value;
                break;
            case StatEnum.StatCt:
                target.CriticalHitLevel += m_Value;
                break;
            case StatEnum.StatAccuracyRate:
                target.AccuracyRate += m_Value;
                break;
            default:
                Debug.Log("StatModifierEffect ApplyEffect nothing to do");
                break;
        }
    }

    public override void ApplyEffect(BattleContext battleContext)
    {
        if (battleContext != null) ApplyEffect(battleContext.Target);
    }
}