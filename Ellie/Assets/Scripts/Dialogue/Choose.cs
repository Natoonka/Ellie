using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using TMPro;

public class Choose : MonoBehaviour
{
    public GameObject ChooseBoxUI;

    // Start is called before the first frame update
    void Start()
    {
        ChooseBoxUI.SetActive(false);
    }

    public void ChooseOption()
    {
        ChooseBoxUI.SetActive(true);
    }

    public void Close()
    {
        ChooseBoxUI.SetActive(false);
    }

    public void Ending(string endName)
    {
        Application.LoadLevel(endName);
    }
}
