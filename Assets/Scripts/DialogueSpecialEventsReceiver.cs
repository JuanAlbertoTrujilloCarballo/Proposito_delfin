using System;
using System.Collections.Generic;
using UnityEngine;

public class DialogueSpecialEventsReceiver : MonoBehaviour
{
    // [SerializeField]
    // private DialoguesContainer dialoguesContainer;
    //
    // [SerializeField] 
    // private DialogueSystem dialogueSystem;
    //
    // [SerializeField] 
    // private List<Transform> speakersList;
    //
    // private Dictionary<Sprite, Transform> speakers;
    //
    // private int speakersIndex;
    //
    // private void Awake()
    // {
    //     speakers = new Dictionary<Sprite, Transform>();
    //
    //     for (int j = 0; j < dialoguesContainer.DialogueDataList.Count; j++)
    //     {
    //         if(speakers.ContainsKey(dialoguesContainer.DialogueDataList[j].DialogueSourceSprite)) continue;
    //         speakers.Add(dialoguesContainer.DialogueDataList[j].DialogueSourceSprite, speakersList[speakersIndex]);
    //         speakersIndex++;
    //     }    
    // }
    //
    // private void OnEnable()
    // {
    //     dialogueSystem.SpecialDialogueActivated.AddListener(SpecialDialogueActivated);
    // }
    //
    // private void OnDisable()
    // {
    //     dialogueSystem.SpecialDialogueActivated.RemoveListener(SpecialDialogueActivated);
    // }
    //
    // private void SpecialDialogueActivated(Sprite arg0, Sprite arg1)
    // {
    //     var transformDesired = speakers[arg0].transform;
    //
    //     transformDesired.TryGetComponent(out Animator)
    //     transformDesired.TryGetComponent(out SpriteRenderer spRenderer);
    //     spRenderer.sprite = arg1;
    // }
}