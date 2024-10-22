namespace STS
{
    public enum GameState : int
    {
        Err = 0, None = 1, Title = 2, Map = 3,
        Field = 4, Battle = 5, End = 6
    }
    public enum FieldType : int
    {
        Empty = 0, Shop = 3,
        MobBattle = 1, BossBattle = 2,
    }
}