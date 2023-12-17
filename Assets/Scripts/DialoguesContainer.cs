using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "DialoguesContainer", fileName = "DialoguesContainer", order = 0)]
public class DialoguesContainer : ScriptableObject
{
    public List<DialogueData> DialogueDataList => dialogueDataList;
    
    [SerializeField] 
    private List<DialogueData> dialogueDataList;

    public DialogueData GetDialogue(string dialogueID)
    {
        return dialogueDataList.Find(x => x.DialogueStringID.Equals(dialogueID));
    }
}
