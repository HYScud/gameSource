public enum ExpTypeEnum
{
    BestFast,
    Faster,
    Fast,
    Slow,
    Slower,
    BestSlow
}

public enum SexTypeEnum
{
    None,
    Male,
    Female,
    UnKnown
}

public enum TypeEnum
{
    None, //无属性
    Normal, //一般
    Fighting, //格斗系
    Flying, //飞行系
    Poison, //毒系
    Ground, //地系
    Rock, //岩石系
    Bug, //虫系
    Ghost, //幽灵系
    Steel, //钢系
    Fire, //火系
    Water, //水系
    Grass, //草系
    Electric, //电系
    Psychic, //超能力
    Ice, //冰系
    Dragon, //龙系
    Dark, //恶系
    Fairy //妖精系
}

public enum NatureTypeEnum
{
    None,
    Hardy, //勤奋
    Lonely, //怕寂寞
    Adamant, //固执
    Naughty, //顽皮
    Brave, //勇敢
    Bold, //大胆
    Docile, //坦率
    Impish, //淘气
    Lax, //乐天
    Relaxed, //悠闲
    Modest, //内敛
    Mild, //慢吞吞
    Bashful, //害羞
    Rash, //马虎
    Quiet, //冷静
    Calm, //温和
    Gentle, //温顺
    Careful, //慎重
    Quirky, //浮躁
    Sassy, //自大
    Timid, //胆小
    Hasty, //急躁
    Jolly, //爽朗
    Naive, //天真
    Serious //认真
}

public enum ShinyTypeEnum
{
    None,
    Square,
    Star,
    Special
}

public enum StatusTypeEnum
{
    None,
    Burn, //烧伤
    Freeze, //冰冻
    Paralysis, //麻痹
    Poison, //中毒
    Sleep, //睡眠，
    BadlyPoison, //剧毒
    Drowsy, //瞌睡
    Fainting //濒死
}

public enum SecondStatusTypeEnum
{
    None,
    Confusion = 1, //混乱
    Infatuation = 2, //着迷
    Nightmare = 3, //噩梦
    Encore = 4, //再来一次
    TormentTorment = 5, //无理取闹
    HealingPrevented = 6, //回复封锁
    Disable = 7, //定身法
    LockOn = 8, //锁定
    Taunt = 9, //挑衅
    Embargo = 10, //查封
    Ignition = 11 //引火状态
}

/******************技能枚举**********************/
public enum MoveTypeEnum
{
    SpecialMove,
    PhysicalMove,
    StatusMove
}

public enum MoveAtkRangeEnum
{
    None = 0,
    SpecificMove = 1, //取决于技能效果
    SelectedPokemonMeFirst = 2, //
    Ally = 3, //盟友
    UserField = 4, //使用者场地的宝可梦
    UserOrAlly = 5, //使用者或者盟友
    OpponentsField = 6, //对手场地
    User = 7, //使用者
    RandomOpponent = 8, //随机一个敌人
    AllOthers = 9, //场上所有的敌人
    Selected = 10, //选择的宝可梦
    AllEnemy = 11, //所有敌人
    EntireField = 12, //整个场地
    UserAndAllies = 13, //使用者及盟友
    All = 14, //场上的所有宝可梦
    AllAllies = 15, //所有盟友
    FaintingPokemon = 16 //濒死的宝可梦
}

/// <summary>
/// 技能接触类型枚举
/// </summary>
public enum MoveContactEnum
{
    None = 0,
    DirectContactAttack, //接触攻击
    NotContactAttack //非接触攻击
}

/// <summary>
/// 技能威力类型
/// </summary>
public enum MovePowerTypeEnum
{
    None = 0,
    Fixed = 1, //固定值
    MaxHp = 2, //最大血量（一击必杀）
    Level = 3, //等级伤害
    PercentCurHp = 4, //当前血量百分比
    PercentMaxHp = 5, //最大血量百分比
    Friendship = 6 //亲密度
}

/// <summary>
/// 技能学习方式
/// </summary>
public enum MoveLearnTypeEnum
{
    None = 0,
    Level = 1, //等级
    HiddenMachine = 2, //HM
    TechnicalMachine = 3, //招式机
    Teach = 4, //教学
    Inherit = 5 //继承（蛋招式）
}

/******************技能枚举End**********************/