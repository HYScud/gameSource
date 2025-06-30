using UnityEngine;

public static class ConditionTool
{
    /*
     * @description 检查条件
     * @param battleContext 战斗中的上下文
     * @param conditionData 触发条件
     */
    public static bool CheckCondition(BattleContext battleContext, ConditionData conditionData)
    {
        var flag = false;
        switch (conditionData.ConditionEnum)
        {
            case ConditionEnum.RoundEnd:
                if (battleContext.CurStage == BattleStage.RoundEnd) flag = true;
                break;
            default:
                Debug.Log("ConditionTool.CheckCondition do not find condition");
                break;
        }

        return flag;
    }
}