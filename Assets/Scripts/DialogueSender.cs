using System.Collections.Generic;
using UnityEngine;

public class DialogueSender : MonoBehaviour
{
        [SerializeField] 
        private List<string> keysToShowList;

        [SerializeField] 
        private DialogueSystem dialogueSystem;

        public void SendNewKeyList()
        { 
          dialogueSystem.ReceiveKeyListAndShow(keysToShowList);
        }
}