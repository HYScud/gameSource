using System;
using System.Collections.Generic;
using UnityEngine;

public class Pokemon
{
    private readonly PokemonBase m_PokemonBase;

    public int curExp { get; set; }
    public Move[] moves { get; } = new Move[4];

    public StatusTypeEnum Status;
    public int statusCounter { get; set; } // 用于睡眠回合计数等

    public List<Move> ForgottenMoves = new();
    private Ability m_CurAbility;
    public Item CurCarriedItem;

    //努力值

    private int level { get; set; }

    public Ability curAbility
    {
        get => m_CurAbility;
        set => m_CurAbility = value ?? throw new ArgumentNullException(nameof(value));
    }

    private int basePointsHp { get; set; } = 0;

    private int basePointsATk { get; set; } = 0;

    private int basePointsSpaTk { get; set; } = 0;

    private int basePointsDef { get; set; } = 0;

    private int basePointsSpDef { get; set; } = 0;

    private int basePointsSpeed { get; set; } = 0;

    private NatureTypeEnum natureType
    {
        get
        {
            if (m_PokemonBase?.PokemonInfo != null) return m_PokemonBase.PokemonInfo.natureType;

            return NatureTypeEnum.None;
        }
    }

    public int maxHp
    {
        get
        {
            if (m_PokemonBase.PokemonInfo.Id == "292")
                return 1;
            else
                return Mathf.FloorToInt((m_PokemonBase.hp * 2 + m_PokemonBase.hp + Mathf.FloorToInt(basePointsHp / 4)) *
                    level / 100f) + 10 + level;
        }
    }

    public int attack =>
        Mathf.FloorToInt(((m_PokemonBase.attack * 2 + attack + basePointsATk / 4) * level / 100f + 5 + level) *
                         PokemonTable.GetNatureEffect(0, natureType));

    public int defense =>
        Mathf.FloorToInt(
            ((m_PokemonBase.defense * 2 + m_PokemonBase.ivDefence + basePointsSpaTk / 4) * level / 100f + 5 + level) *
            PokemonTable.GetNatureEffect(1, natureType));

    public int specialAttack =>
        Mathf.FloorToInt(
            ((m_PokemonBase.specialATk * 2 + m_PokemonBase.ivSpecialAtk + basePointsDef / 4) * level / 100f + 5 +
             level) *
            PokemonTable.GetNatureEffect(2, natureType));

    public int specialDefense =>
        Mathf.FloorToInt(
            ((m_PokemonBase.specialDef * 2 + m_PokemonBase.ivSpecialDef + basePointsSpDef / 4) * level / 100f + 5 +
             level) *
            PokemonTable.GetNatureEffect(3, natureType));

    public int speed =>
        Mathf.FloorToInt(
            ((m_PokemonBase.speed * 2 + m_PokemonBase.ivSpeed + basePointsSpeed / 4) * level / 100f + 5 + level) *
            PokemonTable.GetNatureEffect(4, natureType));

    public Pokemon(PokemonBase pokemonBase, StatusTypeEnum status, Ability curAbility, Item curCarriedItem,
        int basePointsHp, int basePointsATk, int basePointsSpaTk, int basePointsDef, int basePointsSpDef,
        int basePointsSpeed, int curExp, int statusCounter, int level)
    {
        m_PokemonBase = pokemonBase;
        Status = status;
        m_CurAbility = curAbility;
        CurCarriedItem = curCarriedItem;
        this.basePointsHp = basePointsHp;
        this.basePointsATk = basePointsATk;
        this.basePointsSpaTk = basePointsSpaTk;
        this.basePointsDef = basePointsDef;
        this.basePointsSpDef = basePointsSpDef;
        this.basePointsSpeed = basePointsSpeed;
        this.curExp = curExp;
        this.statusCounter = statusCounter;
        this.level = level;
    }

    public bool RemoveStatus()
    {
        if (Status != StatusTypeEnum.none)
        {
            Status = StatusTypeEnum.none;
            return true;
        }
        else
        {
            Debug.Log("Status remove Error. status is null");
            return false;
        }
    }

    public bool AddStatus(StatusTypeEnum statusType)
    {
        if (Status == StatusTypeEnum.none)
        {
            Status = statusType;
            return true;
        }
        else
        {
            Debug.Log("Status add Error. status is not null");
            return false;
        }
    }
}