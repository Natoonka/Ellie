using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndScript : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI dialogueText;

    private Queue<string> sentences;

    public Dialogue dialogue;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
        StartTheTalk(dialogue);
    }

    void StartTheTalk(Dialogue dialogue)
    {
        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }
    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            End();
            return;
        }

        string sentence = sentences.Dequeue();

        dialogueText.text = sentence;
    }
    public void End()
    {
        Application.LoadLevel("Menu");
    }
}
