using System.Collections;
using UnityEngine;
using DG.Tweening;

/// <summary>
/// Dev: Roli Fanfaret
/// </summary>
public class RoadLine : MonoBehaviour
{
    public Transform nextLine;

    private RoadData roadData;
    private Tween tween;

    private IEnumerator Start()
    {
        yield return new WaitForEndOfFrame();

        roadData = ManagerRunner.GetRoadData();

        GoTo();
    }

    private void GoTo()
    {
        tween = transform.DOMove(roadData.endPosition, roadData.speed).SetSpeedBased(true).OnComplete(Restart).SetEase(Ease.Linear);
    }

    private void Restart()
    {
        transform.position = roadData.startPosition;

        StartCoroutine(HandleRestart());
    }

    private IEnumerator HandleRestart()
    {
        float currentDistance = 0;

        while (currentDistance < roadData.distance)
        {
            currentDistance = Vector2.Distance(transform.position, nextLine.position);
            yield return null;
        }

        GoTo();
    }

    public void Stop()
    {
        tween.Kill();
    }
}
