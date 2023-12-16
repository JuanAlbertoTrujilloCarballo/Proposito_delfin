using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenFixerController : MonoBehaviour
{
    [SerializeField] 
    private Camera cameraToRender;
        
    private SpriteRenderer backgroundSize;

    private bool hasCalculatedScreenSize;

    private void OnEnable()
    {
        
    }

    public void DoFixScreenRatio(GameObject go)
    {
        backgroundSize = go.transform.GetChild(0).GetComponent<SpriteRenderer>();
        FixScreenRatio(backgroundSize);
           
    }


    void FixScreenRatio(SpriteRenderer bgSize)
    {
        cameraToRender.backgroundColor = bgSize.color;
            
        if(hasCalculatedScreenSize) return;
        float screenRatio = (float)Screen.width / (float)Screen.height;
        float targetRatio = bgSize.bounds.size.x / bgSize.bounds.size.y;

        if (screenRatio >= targetRatio)
        {
            cameraToRender.orthographicSize = bgSize.bounds.size.y / 2;
        }
        else
        {
            float differenceInSize = targetRatio / screenRatio;
            cameraToRender.orthographicSize = bgSize.bounds.size.y / 2 * differenceInSize;
        }

        hasCalculatedScreenSize = true;
    }
}
