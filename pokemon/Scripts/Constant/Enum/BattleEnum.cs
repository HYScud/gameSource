using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum StatEnum
{
    StatHp = 0,
    StatAtk = 1,
    StatDef = 2,
    StatSpAtk = 3,
    StatSpDef = 4,
    StatSpeed = 5,
    StatCt = 6,
    StatAccuracyRate = 7
}

public enum BattleStage
{
    BattleStart,
    BeforeUseMove,
    BeforeCalculateDamage,
    AfterUseMove,
    OnHurt,
    AfterCalculateDamage,
    RoundEnd,
    BattleEnd
}