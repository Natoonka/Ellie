using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    
    public void OnTriggerStay2D(Collider2D collision)
    {
        FindObjectOfType<DialogueManager>().InteractWith(dialogue);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<DialogueManager>().InteractWith(dialogue);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        FindObjectOfType<DialogueManager>().CantInteract();
    }
}
