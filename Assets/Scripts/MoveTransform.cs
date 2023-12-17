using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class MoveTransform : MonoBehaviour
{
    [SerializeField] 
    private Transform transformToMove;

    [SerializeField] 
    private float amountToMove;

    [SerializeField] 
    private float movementTime;

    public void DoMoveTransform()
    {
        transformToMove.DOMoveX(amountToMove, movementTime).SetRelative(true);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
