using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Move
{
    private readonly MoveBase m_MoveBase;

    public int curPowerPoint { get; set; }

    public Move(MoveBase moveBase, int pp)
    {
        m_MoveBase = moveBase;
        curPowerPoint = pp;
    }

    public override bool Equals(object obj)
    {
        var target = obj as Move;
        if (target == null || target.m_MoveBase == null || m_MoveBase == null)
            return false;
        else
            return m_MoveBase.moveId == target.m_MoveBase.moveId;
    }

    public override int GetHashCode()
    {
        return m_MoveBase.GetHashCode();
    }

    public override string ToString()
    {
        return m_MoveBase.ToString();
    }
}