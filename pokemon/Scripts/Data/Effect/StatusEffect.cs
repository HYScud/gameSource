using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StatusEffect : EffectBase
{
    private StatusTypeEnum m_StatusTypeEnum;
    public int chance { get; set; } = 0;

    public StatusTypeEnum statusTypeEnum
    {
        get => m_StatusTypeEnum;
        set => m_StatusTypeEnum = value;
    }

    private int m_AddOrRemove;

    public int addOrRemove
    {
        get => m_AddOrRemove;
        set => m_AddOrRemove = value;
    }

    protected StatusEffect(StatusTypeEnum statusTypeEnum, int addOrRemove, int chance)
    {
        m_StatusTypeEnum = statusTypeEnum;
        m_AddOrRemove = addOrRemove;
        this.chance = chance;
    }

    private void ApplyEffect(BattlePokemon target)
    {
        switch (m_AddOrRemove)
        {
            case 1:
                if (target.pokemon.Status == m_StatusTypeEnum)
                    target.RemoveStatus();
                break;
            default:
                target.AddStatus(m_StatusTypeEnum);
                break;
        }
    }

    public override void ApplyEffect(BattleContext battleContext)
    {
        ApplyEffect(battleContext.Target);
    }
}