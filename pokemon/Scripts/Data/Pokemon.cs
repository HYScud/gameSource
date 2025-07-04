using System;
using System.Collections.Generic;
using UnityEngine;

public class Pokemon
{
    public PokemonBase pokemonBase { get; }

    public int curExp { get; set; }
    public Move[] moves { get; } = new Move[4];

    public StatusTypeEnum Status;
    public int statusCounter { get; set; } // 用于睡眠回合计数等

    public List<Move> ForgottenMoves = new();
    public Ability m_CurAbility;
    public Item CurCarriedItem;

    public int level { get; set; }

    //努力值
    public int basePointsHp { get; set; } = 0;
    public int basePointsATk { get; set; } = 0;
    public int basePointsSpaTk { get; set; } = 0;
    public int basePointsDef { get; set; } = 0;
    public int basePointsSpDef { get; set; } = 0;

    public int basePointsSpeed { get; set; } = 0;

    //亲密度-美丽度等
    public int BasePointsFriendship = 0;
    public int BasePointsBeauty = 0;
    public int BasePointsCute = 0;
    public int BasePointsSmart = 0;
    public int BasePointsCool = 0;
    public int BasePointsTough = 0;

    public NatureTypeEnum natureType
    {
        get
        {
            if (pokemonBase?.PokemonInfo != null) return pokemonBase.PokemonInfo.natureType;

            return NatureTypeEnum.None;
        }
    }

    public int curHp { get; set; }

    public int maxHp
    {
        get
        {
            if (pokemonBase.PokemonInfo.Id == "292")
                return 1;
            else
                return Mathf.FloorToInt((pokemonBase.hp * 2 + pokemonBase.hp + Mathf.FloorToInt(basePointsHp / 4)) *
                    level / 100f) + 10 + level;
        }
    }

    public Ability curAbility
    {
        get => m_CurAbility;
        set => m_CurAbility = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int attack =>
        Mathf.FloorToInt(((pokemonBase.attack * 2 + attack + basePointsATk / 4) * level / 100f + 5 + level) *
                         PokemonTable.GetNatureEffect(0, natureType));

    public int defense =>
        Mathf.FloorToInt(
            ((pokemonBase.defense * 2 + pokemonBase.ivDefence + basePointsSpaTk / 4) * level / 100f + 5 + level) *
            PokemonTable.GetNatureEffect(1, natureType));

    public int specialAttack =>
        Mathf.FloorToInt(
            ((pokemonBase.specialATk * 2 + pokemonBase.ivSpecialAtk + basePointsDef / 4) * level / 100f + 5 +
             level) *
            PokemonTable.GetNatureEffect(2, natureType));

    public int specialDefense =>
        Mathf.FloorToInt(
            ((pokemonBase.specialDef * 2 + pokemonBase.ivSpecialDef + basePointsSpDef / 4) * level / 100f + 5 +
             level) *
            PokemonTable.GetNatureEffect(3, natureType));

    public int speed =>
        Mathf.FloorToInt(
            ((pokemonBase.speed * 2 + pokemonBase.ivSpeed + basePointsSpeed / 4) * level / 100f + 5 + level) *
            PokemonTable.GetNatureEffect(4, natureType));

    public Pokemon(StatusTypeEnum status, Ability curAbility, Item curCarriedItem, PokemonBase pokemonBase, int curExp,
        int statusCounter, int level, int basePointsHp, int basePointsATk, int basePointsSpaTk, int basePointsDef,
        int basePointsSpDef, int basePointsSpeed, int curHp)
    {
        Status = status;
        m_CurAbility = curAbility;
        CurCarriedItem = curCarriedItem;
        this.pokemonBase = pokemonBase;
        this.curExp = curExp;
        this.statusCounter = statusCounter;
        this.level = level;
        this.basePointsHp = basePointsHp;
        this.basePointsATk = basePointsATk;
        this.basePointsSpaTk = basePointsSpaTk;
        this.basePointsDef = basePointsDef;
        this.basePointsSpDef = basePointsSpDef;
        this.basePointsSpeed = basePointsSpeed;
        this.curHp = curHp;
    }

    public bool RemoveStatus()
    {
        if (Status != StatusTypeEnum.None)
        {
            Status = StatusTypeEnum.None;
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
        if (Status == StatusTypeEnum.None)
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