using UnityEngine;

public class FieldManager : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            BattleManager.Instance.StartBattle(-1);
        }
    }
}
