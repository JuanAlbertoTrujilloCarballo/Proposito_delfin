using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;

public class CameraMover : MonoBehaviour
{
    [SerializeField] 
    private Camera cameraToMove;

    [SerializeField] 
    private Transform finalPoint;

    [SerializeField]
    private CharacterMovement characterMovement;
    
    [SerializeField] 
    private float movementTime;
    
    [SerializeField] 
    private UnityEvent onSceneChangingStart;

    [SerializeField] 
    private UnityEvent onSceneChanged;

    private bool hasReceivedOrder;

    private void Update()
    {
        if (hasReceivedOrder)
        {
            if(characterMovement.IsMoving) return;
            var finalPointNoZ = new Vector3(finalPoint.position.x, finalPoint.position.y, cameraToMove.transform.position.z);
            cameraToMove.transform.DOMove(finalPointNoZ, movementTime).OnStart(()=>
                {
                    onSceneChangingStart.Invoke();
                    hasReceivedOrder = false;
                })
                .OnComplete(()=>
                {
                    onSceneChanged.Invoke();
                    
                }); 
        }
    }

    public void DoMoveCamera()
    {
        hasReceivedOrder = true;
    }

}
