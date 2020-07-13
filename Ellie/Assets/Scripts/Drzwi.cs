using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drzwi : MonoBehaviour
{
    public Dialogue dialogue;
    public Item item;

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (!Inventory.instance.items.Contains(item))
        {
            FindObjectOfType<DialogueManager>().InteractWith(dialogue);
            if (Input.GetKeyDown(KeyCode.Space))
            {

                FindObjectOfType<Choose>().ChooseOption();
            }
        }
        else
        {
            FindObjectOfType<DialogueManager>().InteractWith(dialogue);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                FindObjectOfType<Choose>().Ending("DemoEndKey");
            }
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (!Inventory.instance.items.Contains(item))
        {
            FindObjectOfType<DialogueManager>().InteractWith(dialogue);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                
                FindObjectOfType<Choose>().ChooseOption();

            }
        }
        else
        {
            FindObjectOfType<DialogueManager>().InteractWith(dialogue);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                FindObjectOfType<Choose>().Ending("DemoEndKey");
            }
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        FindObjectOfType<DialogueManager>().CantInteract();
    }
}