using UnityEngine;

/// <summary>
/// Dev: Roli Fanfaret
/// </summary>
public class ManagerRunner : MonoBehaviour
{
    public RoadData roadData;
    public GameObject gameOverGo;
    public TextMesh counterText;
    public PlayerData playerData;

    public static int _counter = 0;

    private static RoadData _roadData;
    private static GameObject _gameOverGo;
    private static TextMesh _counterText;
    private static PlayerData _playerData;

    private void Start()
    {
        _roadData = roadData;
        _gameOverGo = gameOverGo;
        _counterText = counterText;
        _playerData = playerData;
    }

    public static void IncrementCounter()
    {
        _counter += 1;
        _counterText.text = _counter.ToString();

        if (_counter == _playerData.winScore)
            _gameOverGo.SetActive(true);
    }

    public static RoadData GetRoadData()
    {
        return _roadData;
    }

    public static GameObject GetGameOverGameObject()
    {
        return _gameOverGo;
    }

}
