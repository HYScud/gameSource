public static class BattleTools
{
    public static float GetStatValue(StatEnum statEnum, int value)
    {
        float multiple = 1;

        switch (statEnum)
        {
            case StatEnum.StatAtk:
            case StatEnum.StatDef:
            case StatEnum.StatSpAtk:
            case StatEnum.StatSpDef:
            case StatEnum.StatSpeed:
                multiple = GetNormalStatMultiple(statEnum, value);
                break;
        }

        return multiple;
    }

    public static float GetNormalStatMultiple(StatEnum statEnum, int value)
    {
        var numerator = 60.0;
        var multipleArr = new[] { 10.0, 12.0, 15.0, 20.0, 30.0, 60.0, 90.0, 120.0, 150.0, 180.0 };
        var index = 5 + value;
        return (float)(multipleArr[index] / numerator);
    }
}