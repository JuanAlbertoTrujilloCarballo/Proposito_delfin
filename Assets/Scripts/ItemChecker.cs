using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ItemChecker : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> pickedItemsList;

    [SerializeField] 
    private List<GameObject> posibleListOne;
    
    [SerializeField] 
    private List<GameObject> posibleListTwo;

    [SerializeField]
    private UnityEvent onPickedAll;
    
    [SerializeField]
    private UnityEvent onNotPickedAll;

    private bool hasPickedAll;

    public void CheckIfItemsPicked()
    {
        for (int i = 0; i < pickedItemsList.Count; i++)
        {
            if (!pickedItemsList[i].activeInHierarchy)
            {
                hasPickedAll = false;
                break;
            }
        }

        hasPickedAll = true;

        bool isAnyOfThemActive = false;
        for (int i = 0; i < posibleListOne.Count; i++)
        {
            if(!posibleListOne[i].activeInHierarchy) continue;
            isAnyOfThemActive = true;
        }
        
        bool isAnyOfThemActive2 = false;
        for (int i = 0; i < posibleListTwo.Count; i++)
        {
            if(!posibleListTwo[i].activeInHierarchy) continue;
            isAnyOfThemActive2 = true;
        }

        if (!isAnyOfThemActive || !isAnyOfThemActive2)
            hasPickedAll = false;
            
        
        
        if(hasPickedAll)
            onPickedAll.Invoke();
        else
            onNotPickedAll.Invoke();
    }
}
