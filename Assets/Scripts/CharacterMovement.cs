using System.Collections.Generic;
using DG.Tweening;
using Lean.Touch;
using UnityEngine;
using UnityEngine.Events;

public class CharacterMovement : MonoBehaviour
{
    public float MovementTime => movementTime;
    
    [SerializeField] 
    private Transform transformToMove;

    [SerializeField] 
    private float movementTime;

    [SerializeField]
    UnityEvent onMovementStart;

    [SerializeField]
    UnityEvent onMovementFinished;

    private List<LeanFinger> currentDetectedFingersList;
    private LeanFingerFilter leanFingerFilter = new LeanFingerFilter(true);
    int desiredFingerInput = 0;
    private Vector3 pointToMove;


    private void Update()
    {
        DoDetectInputTouch();
    }
    public void DoDetectInputTouch()
    {
        currentDetectedFingersList = leanFingerFilter.UpdateAndGetFingers(true);
        if (currentDetectedFingersList.Count <= 0)  return;
        pointToMove.x = currentDetectedFingersList[0].GetLastWorldPosition(10f).x;
        pointToMove.y = transformToMove.position.y;
        pointToMove.z = transformToMove.position.z;
        transformToMove.DOMove(pointToMove, movementTime).SetEase(Ease.Linear);


    }

}
