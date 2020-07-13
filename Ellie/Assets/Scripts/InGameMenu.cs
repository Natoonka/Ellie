using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class InGameMenu : MonoBehaviour {

 public static bool GameisPaused = false;
 public GameObject pauseMenuUI;
 public GameObject controlsUI;

 void Start () 
 {
  pauseMenuUI.SetActive (false);
  controlsUI.SetActive (false);
 }

 // Update is called once per frame
 void Update () {
  if (Input.GetKeyDown(KeyCode.Escape))
  {
   if (GameisPaused) 
   {
    Resume();
   } else 
   {
    Pause();
   }
 }
}
 void Resume ()
 {
  pauseMenuUI.SetActive (false);
  controlsUI.SetActive (false);
  Time.timeScale = 1f;
  GameisPaused = false;
 }
 void Pause ()
 {
  pauseMenuUI.SetActive (true);
  Time.timeScale = 0f;
  GameisPaused = true;
 }
 public void MainMenu ()
 {
     Application.LoadLevel("Menu");
 }
 public void QuitGame ()
 {
     Debug.Log("Wyszedłeś z gry");
     Application.Quit();
 }
}
