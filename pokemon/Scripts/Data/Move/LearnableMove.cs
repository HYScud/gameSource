using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnableMove
{
    public LearnableMove(MoveBase learnableMoveBase, int level, MoveLearnTypeEnum moveLearnedTypeEnum)
    {
        this.learnableMoveBase = learnableMoveBase;
        this.level = level;
        this.moveLearnedTypeEnum = moveLearnedTypeEnum;
    }

    public MoveBase learnableMoveBase { get; }

    public int level { get; }

    public MoveLearnTypeEnum moveLearnedTypeEnum { get; }
}