using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattlePokemon
{
    public int posIndex;
    public Pokemon pokemon;
    private int criticalHitLevel = 0;
    private int accuracyRate = 0;

    public int[] normalStatLevel = new[] { 0, 0, 0, 0, 0 };

    public BattlePokemon(int posIndex, Pokemon pokemon)
    {
        this.posIndex = posIndex;
        this.pokemon = pokemon;
    }

    public int CriticalHitLevel
    {
        get
        {
            var hitLevelList = new int[] { 24, 8, 2, 1 };
            return hitLevelList[criticalHitLevel];
        }
        set => criticalHitLevel = value;
    }

    public int AccuracyRate
    {
        get
        {
            var accuracyRateList = new int[] { 24, 8, 2, 1 };
            return accuracyRateList[accuracyRate];
        }
        set => criticalHitLevel = value;
    }

    public void RemoveStatus()
    {
        if (pokemon != null)
        {
            var flag = pokemon.RemoveStatus();
            if (flag)
            {
                Debug.Log("RemoveStatus true");
            }
            else
            {
            }
        }
        else
        {
            Debug.LogError("RemoveStatus Error pokemon is null");
        }
    }

    public void AddStatus(StatusTypeEnum statusTypeEnum)
    {
        if (pokemon != null)
        {
            var flag = pokemon.AddStatus(statusTypeEnum);
            if (flag)
            {
                Debug.Log("AddStatus true");
            }
            else
            {
            }
        }
        else
        {
            Debug.LogError("AddStatus Error pokemon is null");
        }
    }

    public void TakeDamage(float damage)
    {
    }
}