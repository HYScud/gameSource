using System.Collections.Generic;

public class PokemonBase
{
    public readonly PokemonInfo PokemonInfo;
    public TypeEnum pokemonType1 { get; set; }
    public TypeEnum pokemonType2 { get; set; }

    private ShinyTypeEnum m_ShinyTypeEnum;
    public int curTotalExp { get; set; } = 0;

    //基本属性-种族值
    public int hp { get; set; }
    public int attack { get; set; }
    public int defense { get; set; }
    public int specialATk { get; set; }
    public int specialDef { get; set; }

    public int speed { get; set; }

    //基本属性-个体值
    public int ivHp { get; set; } = 0;
    public int ivAttack { get; set; } = 0;
    public int ivDefence { get; set; } = 0;
    public int ivSpecialAtk { get; set; } = 0;
    public int ivSpecialDef { get; set; } = 0;
    public int ivSpeed { get; set; } = 0;

    public List<LearnableMove> AllLearnableMoves = new();
    public List<Item> AllCarryItem = new();
    public List<Ability> AllAbilities = new();

    public PokemonBase(PokemonInfo pokemonInfo, TypeEnum pokemonType1, TypeEnum pokemonType2,
        ShinyTypeEnum shinyTypeEnum, int curTotalExp, int hp, int attack, int defense, int specialATk, int specialDef,
        int speed, int ivHp, int ivAttack, int ivDefence, int ivSpecialAtk, int ivSpecialDef, int ivSpeed)
    {
        PokemonInfo = pokemonInfo;
        this.pokemonType1 = pokemonType1;
        this.pokemonType2 = pokemonType2;
        m_ShinyTypeEnum = shinyTypeEnum;
        this.curTotalExp = curTotalExp;
        this.hp = hp;
        this.attack = attack;
        this.defense = defense;
        this.specialATk = specialATk;
        this.specialDef = specialDef;
        this.speed = speed;
        this.ivHp = ivHp;
        this.ivAttack = ivAttack;
        this.ivDefence = ivDefence;
        this.ivSpecialAtk = ivSpecialAtk;
        this.ivSpecialDef = ivSpecialDef;
        this.ivSpeed = ivSpeed;
    }
}