using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    //[System.Obsolete]
    public void ChangeScene(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }
    public void QuitGame()
    {
        Debug.Log("Wyszedłeś z gry");
        Application.Quit();
    }
}
