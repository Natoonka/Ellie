using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Riddle
{
    [TextArea(3, 6)]
    public string riddleBody;

    public string right, wrong;
}
