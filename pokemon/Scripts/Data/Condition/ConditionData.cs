using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionData
{
    public ConditionEnum ConditionEnum;
    public float ConditionValue;

    public ConditionData(ConditionEnum conditionEnum, float conditionValue)
    {
        ConditionEnum = conditionEnum;
        ConditionValue = conditionValue;
    }

    public ConditionData(ConditionEnum conditionEnum)
    {
        ConditionEnum = conditionEnum;
    }
}