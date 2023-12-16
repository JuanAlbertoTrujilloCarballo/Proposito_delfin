using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    [SerializeField] private GameObject medicine;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if(medicine.activeSelf == true)
        {
            Debug.Log("Aqui");
        }
        else
        {
            Debug.Log("Hola");
        }
    }
}
