using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokemonTable
{

    public static float[][] typeChart;//进攻方-防守方

    public static string[][] type_Color;

    public static float[][] natureChart;

    public static float GetNatureEffect(int index, NatureTypeEnum natureTypeEnum)
    {
        if (natureChart == null|| (int)natureTypeEnum >= natureChart.Length|| index > natureChart[0].Length)
        {
            Debug.LogError("获取性格修正失败");
            return 0;
        }
        return natureChart[(int)natureTypeEnum][index];
    }
    public static float GetTypeEffect(int index, TypeEnum typeEnum)
    {
        if (typeChart == null || typeChart[index] == null || typeChart[index].Length == 0 || typeEnum == TypeEnum.None)
        {
            Debug.LogError("获取性格修正失败");
            return 0;
        }
        return typeChart[index][(int)typeEnum];
    }
    // public static string GetTypeColorEffect(int index, UITypeColorEnum TypeColorEnum)
    // {
    //     if (Type_Color == null || Type_Color[index] == null || Type_Color[index].Length == 0)
    //     {
    //         Debug.LogError("获取颜色失败");
    //         return "";
    //     }
    //     return Type_Color[index][(int)TypeColorEnum];
    // }
}
