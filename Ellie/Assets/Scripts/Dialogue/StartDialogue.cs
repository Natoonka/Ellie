using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class StartDialogue
{

    public string[] names;

    [TextArea(2, 4)]
    public string[] sentences;

}