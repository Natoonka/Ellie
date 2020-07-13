using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueItemAdded : MonoBehaviour
{
    public Dialogue dialogue1, dialogue2;
    public Item item;

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (!Inventory.instance.items.Contains(item))
        {
            FindObjectOfType<DialogueManager>().InteractWith(dialogue1);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                FindObjectOfType<DialogueManager>().StartDialogue(dialogue1);
                Inventory.instance.Add(item);
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
                FindObjectOfType<DialogueManager>().StartDialogue(dialogue1);
                Inventory.instance.Add(item);
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
}
