using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestController : MonoBehaviour
{
    private int cont = 0;
    [SerializeField] private GameObject scroll, firstOpen, secondOpen, traba;
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
        scroll.SetActive(true);
        ShowConversation();

    }
    public void ShowConversation()
    {
        if (cont == 0)
        {
            firstOpen.SetActive(true);
            traba.SetActive(true);
            cont++;
            Debug.Log(cont);
        }
        else if (cont > 0)
        {
            secondOpen.SetActive(true);
            Debug.Log("Second");
        }
    }
}
