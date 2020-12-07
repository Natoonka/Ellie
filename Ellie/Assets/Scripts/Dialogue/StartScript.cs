using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartScript : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI dialogueText;
    [SerializeField] public TextMeshProUGUI nameText;

    private Queue<string> sentences;
    private Queue<string> names;

    public StartDialogue dialogue;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
        names = new Queue<string>();
        StartTheTalk(dialogue);
    }

    void StartTheTalk(StartDialogue dialogue)
    {
        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        foreach (string name in dialogue.names)
        {
            names.Enqueue(name);
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
        string name = names.Dequeue();

        dialogueText.text = sentence;
        nameText.text = name;
    }
    public void End()
    {
        Application.LoadLevel("PokojEllie");
    }
}
