using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
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

                FindObjectOfType<Choose>().ChooseOption();
            }
        }
        else
        {
            FindObjectOfType<DialogueManager>().InteractWith(dialogue2);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                FindObjectOfType<DialogueManager>().StartDialogue(dialogue2);
                FindObjectOfType<Choose>().Ending("DemoEndKey");
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
                
                FindObjectOfType<Choose>().ChooseOption();

            }
        }
        else
        {
            FindObjectOfType<DialogueManager>().InteractWith(dialogue2);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                FindObjectOfType<DialogueManager>().StartDialogue(dialogue2);
                FindObjectOfType<Choose>().Ending("DemoEndKey");
            }
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        FindObjectOfType<DialogueManager>().CantInteract();
    }
}