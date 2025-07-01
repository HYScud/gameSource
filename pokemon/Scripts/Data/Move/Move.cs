using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Move
{
    public MoveBase moveBase { get; }

    public int curPowerPoint { get; set; }

    public Move(MoveBase moveBase, int pp)
    {
        this.moveBase = moveBase;
        curPowerPoint = pp;
    }

    public MoveTypeEnum GetMoveType()
    {
        return moveBase.moveTypeEnum;
    }

    public int GetMovePower()
    {
        return moveBase.movePower;
    }

    public override bool Equals(object obj)
    {
        var target = obj as Move;
        if (target == null || target.moveBase == null || moveBase == null)
            return false;
        else
            return moveBase.moveId == target.moveBase.moveId;
    }

    public override int GetHashCode()
    {
        return moveBase.GetHashCode();
    }

    public override string ToString()
    {
        return moveBase.ToString();
    }
}