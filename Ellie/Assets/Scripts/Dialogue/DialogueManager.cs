using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI nameText;
    [SerializeField] public TextMeshProUGUI dialogueText;
    [SerializeField] public TextMeshProUGUI interactText;

    public Animator animatorD, animatorI;

    private Queue<string> sentences;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void InteractWith(Dialogue dialogue)
    {
        interactText.text = dialogue.name;
        animatorI.SetBool("isInRange", true);
    }
    public void CantInteract()
    {
        animatorI.SetBool("isInRange", false);
    }

    public void StartDialogue(Dialogue dialogue)
    {
        animatorD.SetBool("IsOpen", true);

        nameText.text = dialogue.name;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
        Debug.Log("Interacting with" + dialogue.name);

    }
    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();

        dialogueText.text = sentence;
    }
   public void EndDialogue()
    {
        animatorD.SetBool("IsOpen", false);
        Debug.Log("End of interaction");
    }

}
