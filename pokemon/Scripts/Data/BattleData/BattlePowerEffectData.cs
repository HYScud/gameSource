public class BattlePowerModifyData
{
    public float SameTypeModify;
    public float TypeModify;
    public float AbilityModify;
    public float ItemModify;
    public float WeatherModify;
    public float TerrainModify;
    public float OtherModify;

    public float sameTypeModify
    {
        get => SameTypeModify;
        set => SameTypeModify = value;
    }

    public float typeModify
    {
        get => TypeModify;
        set => TypeModify = value;
    }

    public float abilityModify
    {
        get => AbilityModify;
        set => AbilityModify = value;
    }

    public float itemModify
    {
        get => ItemModify;
        set => ItemModify = value;
    }

    public float weatherModify
    {
        get => WeatherModify;
        set => WeatherModify = value;
    }

    public float terrainModify
    {
        get => TerrainModify;
        set => TerrainModify = value;
    }

    public float otherModify
    {
        get => OtherModify;
        set => OtherModify = value;
    }

    public BattlePowerModifyData()
    {
        InitiatedAllParam();
    }

    public BattlePowerModifyData(float sameTypeModify, float typeModify, float abilityModify, float itemModify,
        float weatherModify, float terrainModify, float otherModify)
    {
        SameTypeModify = sameTypeModify;
        TypeModify = typeModify;
        AbilityModify = abilityModify;
        ItemModify = itemModify;
        WeatherModify = weatherModify;
        TerrainModify = terrainModify;
        OtherModify = otherModify;
    }

    public void InitiatedAllParam()
    {
        SameTypeModify = 1;
        TypeModify = 1;
        AbilityModify = 1;
        ItemModify = 1;
        WeatherModify = 1;
        TerrainModify = 1;
        OtherModify = 1;
    }

    public float GetAllModify()
    {
        return SameTypeModify * TypeModify * AbilityModify * ItemModify * WeatherModify * TerrainModify * OtherModify;
    }
}