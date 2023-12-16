using System;
using System.Collections.Generic;
using DG.Tweening;
using Lean.Touch;
using UnityEngine;
using UnityEngine.Events;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private SpriteRenderer currentSprite;
    
    [SerializeField] 
    private Transform transformToMove;

    [SerializeField] 
    private float speed;

    [SerializeField] 
    private Animator animator;

    private List<LeanFinger> currentDetectedFingersList;
    private LeanFingerFilter leanFingerFilter = new LeanFingerFilter(true);
    int desiredFingerInput = 0;
    private Vector3 pointToMove;
    public bool IsMoving;

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
        leanFingerFilter.IgnoreStartedOverGui = false;
        currentDetectedFingersList = leanFingerFilter.UpdateAndGetFingers(true);

        if (currentDetectedFingersList.Count > 0)
        {
            pointToMove = currentDetectedFingersList[0].GetLastWorldPosition(10f);
            
            if (currentDetectedFingersList[0].IsOverGui)
            {
                print("Yes");
            }
        }

       

        animator.SetBool("IsWalking", IsMoving);
        if (ComparingVectorsStaticClass.AreVectorkEquals(pointToMove, transformToMove.position))
        {
            currentSprite.flipX = false;
            return;
        }
        pointToMove.y = transformToMove.position.y;
        pointToMove.z = transformToMove.position.z;
        var step = speed * Time.deltaTime;
        
        
        transformToMove.position = Vector3.MoveTowards(transformToMove.position, pointToMove, step);
        IsMoving = !ComparingVectorsStaticClass.AreVectorkEquals(pointToMove, transformToMove.position);
        
        var direction = pointToMove - transformToMove.position;
        
        direction.Normalize();

        if (direction.x > 0)
            currentSprite.flipX = true;
        else
            currentSprite.flipX = false;

    }
    
    public static class ComparingVectorsStaticClass
    {
        public static bool AreVectorkEquals(Vector3 vectorOne, Vector3 vectorTwo)
        {
            return Vector3.SqrMagnitude(vectorOne - vectorTwo) < 0.01f;
        }
    }

}
