using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject toggleGo;

    private void OnEnable()
    {
        StopGame();
    }

    private void StopGame()
    {
        toggleGo.SetActive(false);
        StopAllRoadLines();
    }

    private void StopAllRoadLines()
    {
        RoadLine[] roadLines = FindObjectsOfType<RoadLine>();

        foreach(RoadLine roadLine in roadLines)
        {
            roadLine.Stop();
        }
    }
}
