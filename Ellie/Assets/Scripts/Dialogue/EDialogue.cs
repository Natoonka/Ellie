using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EDialogue
{

    public string name;

    [TextArea(2, 4)]
    public string[] sentences;

    public GameObject[] image;

    //public string nice;
    //public string mean;

}
