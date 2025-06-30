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

    public BattleContext(BattlePokemon source, BattlePokemon target, BattleStage curStage, Move curUsedMove)
    {
        Source = source;
        Target = target;
        CurStage = curStage;
        CurUsedMove = curUsedMove;
    }

    public BattleContext(BattlePokemon source, BattlePokemon target, BattleStage curStage)
    {
        Source = source;
        Target = target;
        CurStage = curStage;
    }

    public BattleContext(BattlePokemon target, BattleStage curStage, Move curUsedMove)
    {
        Target = target;
        CurStage = curStage;
        CurUsedMove = curUsedMove;
    }

    public BattleContext(BattlePokemon source, BattlePokemon target, BattleStage curStage, int damage,
        WeatherData weatherData, Move curUsedMove, TerrainData terrainData, float damageMultiplier)
    {
        Source = source;
        Target = target;
        CurStage = curStage;
        Damage = damage;
        WeatherData = weatherData;
        CurUsedMove = curUsedMove;
        TerrainData = terrainData;
        DamageMultiplier = damageMultiplier;
    }
}