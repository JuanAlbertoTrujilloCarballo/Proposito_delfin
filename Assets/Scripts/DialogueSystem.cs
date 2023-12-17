using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class DialogueSystem : MonoBehaviour
{

    [SerializeField] 
    private List<DialogueData> dialogueDataList;
    
    // [SerializeField]
    // private DialoguesContainer dialoguesContainer;

    [SerializeField]
    private GameObject dialogueUIContainer;

    [SerializeField] 
    private Button messageButton;

    [SerializeField] 
    private Image talkerProfile; 
    
    [SerializeField] 
    private TextMeshProUGUI textToShow;

    [SerializeField] 
    private List<string> keysToShowList;

    [SerializeField] 
    private UnityEvent onDialogueActivated;
    
    [SerializeField] 
    private UnityEvent onDialogueDectivated;

    private DialogueData currentDialogue;
    
    private int index;

    private void Awake()
    {
        TurnOnDialogues();
    }

    public void DoSendKeyToContainer(string key)
    {
        currentDialogue = GetDialogue(key);
        textToShow.SetText(currentDialogue.DialogueContentString);
        talkerProfile.sprite = currentDialogue.DialogueSourceSprite;
        StartCoroutine(WaitForTime(currentDialogue.WaitingTime, currentDialogue.OnWaitingDialogue.Invoke, currentDialogue.OnStopWaitingTime.Invoke));
    }

    public void NextDialogue()
    {
        SendKeyToContainer();
    }

    public void ReceiveKeyListAndShow(List<string> list)
    {
        keysToShowList = list;
        index = 0;
        TurnOnDialogues();
    }

    private void SendKeyToContainer()
    {
        if (index >= keysToShowList.Count)
        {
            TurnOffDialogues();
            currentDialogue.OnThisDialogueClosedTheConversation.Invoke();
            return;
        }
        DoSendKeyToContainer(keysToShowList[index]);
        index++;
    }

    private void TurnOffDialogues()
    {
        dialogueUIContainer.SetActive(false);
        onDialogueDectivated.Invoke();
    }
    
    private void TurnOnDialogues()
    {
        dialogueUIContainer.SetActive(true);
        NextDialogue();
        onDialogueActivated.Invoke();
    }

    IEnumerator WaitForTime(float timeToWait, Action callbackOne, Action callbackTwo)
    {
        callbackOne.Invoke();
        messageButton.enabled = false;
        yield return new WaitForSeconds(timeToWait);
        callbackTwo.Invoke();
        messageButton.enabled = true;
    }
    
    private DialogueData GetDialogue(string dialogueID)
    {
        return dialogueDataList.Find(x => x.DialogueStringID.Equals(dialogueID));
    }
}

[System.Serializable]
public class DialogueData
{
    public string DialogueStringID => dialogueStringID;

    public Sprite DialogueSourceSprite => dialogueSourceSprite;

    public string DialogueContentString => dialogueContentString;

    public float WaitingTime => waitingTime;
    
    //public Sprite SpecialSprite => specialSprite;

    public UnityEvent OnWaitingDialogue => onWaitingDialogue;
    //
     public UnityEvent OnStopWaitingTime => onStopWaitingTime;

     public UnityEvent OnThisDialogueClosedTheConversation => onThisDialogueClosedTheConversation;

     [SerializeField]
    private string dialogueStringID; 
    
    [SerializeField] 
    private Sprite dialogueSourceSprite;

    [SerializeField] 
    private string dialogueContentString;

    [SerializeField]
    private float waitingTime;
    
    // [SerializeField] 
    // private Sprite specialSprite;

    [SerializeField]
    private UnityEvent onWaitingDialogue;
    
    [SerializeField]
    private UnityEvent onStopWaitingTime;

    [SerializeField] 
    private UnityEvent onThisDialogueClosedTheConversation;



}
