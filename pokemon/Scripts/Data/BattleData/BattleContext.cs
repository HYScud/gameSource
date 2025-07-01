public class BattleContext
{
    public BattlePokemon Source;
    public BattlePokemon Target;
    public BattleStage CurStage;
    public int Damage;
    public WeatherData WeatherData;
    public Move CurUsedMove;
    public TerrainData TerrainData;
    public float DamageMultiplier = 1.0f;
    public float MovePowerMultiplier = 1.0f;
    public int[] StatsValue = new[] { 0, 0, 0, 0, 0 };
    public BattlePowerModifyData BattlePowerModifyData;
    public BattleBaseValueModify BattleBaseValueModify;

    public BattleContext(BattlePokemon source, BattlePokemon target, BattleStage curStage, int damage,
        WeatherData weatherData, Move curUsedMove, TerrainData terrainData, float damageMultiplier,
        BattlePowerModifyData battlePowerModifyData, BattleBaseValueModify battleBaseValueModify)
    {
        Source = source;
        Target = target;
        CurStage = curStage;
        Damage = damage;
        WeatherData = weatherData;
        CurUsedMove = curUsedMove;
        TerrainData = terrainData;
        DamageMultiplier = damageMultiplier;
        BattlePowerModifyData = battlePowerModifyData;
        BattleBaseValueModify = battleBaseValueModify;
    }
}