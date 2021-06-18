using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndScriptSecret : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI dialogueText;

    private Queue<string> sentences;
    private Queue<GameObject> images;
    public EDialogue dialogue;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
        images = new Queue<GameObject>();

        StartTheTalk(dialogue);
        
    }

    void StartTheTalk(EDialogue dialogue)
    {
        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        foreach (GameObject image in dialogue.image)
        {
            image.SetActive(false);
            images.Enqueue(image);
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
        GameObject image = images.Dequeue();

        dialogueText.text = sentence;
        image.SetActive(true);
    }
    public void End()
    {
        Application.LoadLevel("Menu");
    }
}
