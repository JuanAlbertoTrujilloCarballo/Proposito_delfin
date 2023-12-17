using UnityEngine;
using UnityEngine.Events;

public class DistanceChecker : MonoBehaviour
{
    [SerializeField]
    private Transform transformToCheckDistanceWith;

    [SerializeField] 
    private float distanceTolerance;

    [SerializeField]
    private UnityEvent onDistanceAccepted;
    
    [SerializeField]
    private UnityEvent onDistanceRejected;

    public void CheckDistanceWith()
    {
        var distance = Vector3.Distance(transformToCheckDistanceWith.position, transform.position);

        if (distance < distanceTolerance)
            onDistanceAccepted.Invoke();
        else
            onDistanceRejected.Invoke();
        
    }
}