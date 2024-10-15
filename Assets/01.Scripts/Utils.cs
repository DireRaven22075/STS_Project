using STS.Manager;
public struct Managers
{
    public static UIManager UI { get; private set; }
    public static InputManager Input { get; private set; }
    // public static ResourceManager Resource { get; private set; }
    // public static SoundManager Sound { get; private set; }
    // public static DataManager Data { get; private set; }
    public static GameManager Game { get; private set; }

    public static void Initialize()
    {
        UI = UIManager.Instance;
        Input = InputManager.Instance;
        // Resource = ResourceManager.Instance;
        // Sound = SoundManager.Instance;
        // Data = DataManager.Instance;
        Game = GameManager.Instance;
    }
}