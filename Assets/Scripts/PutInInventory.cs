using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PutInInventory : MonoBehaviour
{
    [SerializeField] private GameObject itemDesactivate, itemInventory;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        
        itemInventory.SetActive(true);
        itemDesactivate.SetActive(false);
        //throw new System.NotImplementedException();
    }

}
