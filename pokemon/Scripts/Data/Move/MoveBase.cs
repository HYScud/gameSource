using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBase : EffectObjectBase
{
    public string moveId { get; set; }

    public string moveName { get; set; }

    public int movePower { get; set; }

    public int powPoint { get; set; }

    public TypeEnum moveType { get; set; }

    public string desc { get; set; }

    public int accuracy { get; set; }

    public int priority { get; set; }

    public int ctLevel { get; set; }

    public MoveAtkRangeEnum moveAtkRangeEnum { get; set; } = MoveAtkRangeEnum.None;

    public MoveContactEnum moveContactEnum { get; set; } = MoveContactEnum.None;

    public MoveTypeEnum moveTypeEnum { get; set; } = MoveTypeEnum.PhysicalMove;

    public bool bIsEffectByProtect { get; set; } = false;

    public bool bIsEffectByMagicCoat { get; set; } = false;

    public bool bIsEffectBySnatch { get; set; } = false;

    public bool bIsEffectByMirror { get; set; } = false;

    public bool bIsEffectByItem { get; set; } = false;

    public MovePowerTypeEnum movePowerType { get; set; }

    public MoveBase(string moveId, string moveName, int movePower, int powPoint, TypeEnum moveType, string desc,
        int accuracy, int priority, int ctLevel, MoveAtkRangeEnum moveAtkRangeEnum, MoveContactEnum moveContactEnum,
        MoveTypeEnum moveTypeEnum, bool bIsEffectByProtect, bool bIsEffectByMagicCoat, bool bIsEffectBySnatch,
        bool bIsEffectByMirror, bool bIsEffectByItem, MovePowerTypeEnum movePowerType)
    {
        this.moveId = moveId;
        this.moveName = moveName;
        this.movePower = movePower;
        this.powPoint = powPoint;
        this.moveType = moveType;
        this.desc = desc;
        this.accuracy = accuracy;
        this.priority = priority;
        this.ctLevel = ctLevel;
        this.moveAtkRangeEnum = moveAtkRangeEnum;
        this.moveContactEnum = moveContactEnum;
        this.moveTypeEnum = moveTypeEnum;
        this.bIsEffectByProtect = bIsEffectByProtect;
        this.bIsEffectByMagicCoat = bIsEffectByMagicCoat;
        this.bIsEffectBySnatch = bIsEffectBySnatch;
        this.bIsEffectByMirror = bIsEffectByMirror;
        this.bIsEffectByItem = bIsEffectByItem;
        this.movePowerType = movePowerType;
    }

    public void InitEffectListByTable()
    {
    }
}