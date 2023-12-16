using System.Collections.Generic;
using Lean.Touch;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] 
    private Transform transformToMove;

    [SerializeField]
    private float speed;
    private List<LeanFinger> currentDetectedFingersList;
    private LeanFingerFilter leanFingerFilter = new LeanFingerFilter(true);
    int desiredFingerInput = 0;
    private Vector3 pointToMove;

    private void Awake()
    {
        pointToMove = transformToMove.position;
    }

    private void Update()
    {
        DoDetectInputTouch();
    }
    public void DoDetectInputTouch()
    {
        currentDetectedFingersList = leanFingerFilter.UpdateAndGetFingers(true);
       if (currentDetectedFingersList.Count > 0)
       {
            pointToMove = currentDetectedFingersList[0].GetLastWorldPosition(10f);
            pointToMove.y = transformToMove.position.y;
            pointToMove.z = transformToMove.position.z;
           
       }
       if(ComparingVectorsStaticClass.AreVectorkEquals(transformToMove.position, pointToMove)) return;
        transformToMove.position = Vector3.MoveTowards(transformToMove.position, pointToMove, speed * Time.deltaTime);
    }
}


public static class ComparingVectorsStaticClass
{
    public static bool AreVectorkEquals(Vector3 vectorOne, Vector3 vectorTwo)
    {
        return Vector3.SqrMagnitude(vectorOne - vectorTwo) < 0.01f;
    }
}
