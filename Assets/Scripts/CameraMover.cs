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

    public void DoMoveCamera()
    {
        var finalPointNoZ = new Vector3(finalPoint.position.x, finalPoint.position.y, cameraToMove.transform.position.z);
        cameraToMove.transform.DOMove(finalPointNoZ, movementTime).OnStart(onSceneChangingStart.Invoke).OnComplete(onSceneChanged.Invoke).SetDelay(characterMovement.MovementTime + .1f);
    }

    // private void OnTriggerExit2D(Collider2D other)
    // {
    //     var finalPointNoZ = new Vector3(finalPoint.position.x, finalPoint.position.y, cameraToMove.transform.position.z);
    //     cameraToMove.transform.DOMove(finalPointNoZ, movementTime).OnComplete(onSceneChanged.Invoke);
    // }

}
