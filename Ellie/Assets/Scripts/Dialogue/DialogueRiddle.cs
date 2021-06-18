using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueRiddle : MonoBehaviour
{
    public Dialogue dialogue1, dialogue2, dialogue3, dialogue4;
    public Riddle riddle;
    public Item item;

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (!Inventory.instance.items.Contains(item))
        {
            FindObjectOfType<DialogueManager>().InteractWith(dialogue1);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                FindObjectOfType<DialogueManager>().StartDialogueR(dialogue1, riddle, dialogue1.name);
            }
        }
        else
        {
            FindObjectOfType<DialogueManager>().InteractWith(dialogue2);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                FindObjectOfType<DialogueManager>().StartDialogue(dialogue2);
            }
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (!Inventory.instance.items.Contains(item))
        {
            FindObjectOfType<DialogueManager>().InteractWith(dialogue1);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                FindObjectOfType<DialogueManager>().StartDialogueR(dialogue1, riddle, dialogue1.name);
            }
        }
        else
        {
            FindObjectOfType<DialogueManager>().InteractWith(dialogue2);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                FindObjectOfType<DialogueManager>().StartDialogue(dialogue2);
            }
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        FindObjectOfType<DialogueManager>().CantInteract();
    }
    public void Correct()
    {
        FindObjectOfType<Choose>().Close();
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue3);
        Inventory.instance.Add(item);
    }
    public void Wrong()
    {
        FindObjectOfType<Choose>().Close();
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue4);
        Application.LoadLevel("Secret");
    }
}