using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ConditionData
{
    public ConditionEnum ConditionEnum;
    public float ConditionValue;

    protected ConditionData(ConditionEnum conditionEnum, float conditionValue)
    {
        ConditionEnum = conditionEnum;
        ConditionValue = conditionValue;
    }

    protected ConditionData(ConditionEnum conditionEnum)
    {
        ConditionEnum = conditionEnum;
    }
}