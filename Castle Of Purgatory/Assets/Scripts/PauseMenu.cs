using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
  public static bool GameIsPaused;
  public GameObject pauseMenu;

  // Update is called once per frame
  void Update()
  {
    if (Input.GetKeyDown(KeyCode.Escape))
    {
      if (GameIsPaused)
      {
        Resume();
      }
      else
      {
        Pause();
      }
    }
  }

  public void Resume()
  {
    GetComponent<Canvas>().enabled = false;
    Time.timeScale = 1f;
    GameIsPaused = false;
  }

  void Pause()
  {
    GetComponent<Canvas>().enabled = true;
    Time.timeScale = 0f;
    GameIsPaused = true;
  }

  public void Quit()
  {
    Time.timeScale = 1f;
    GameIsPaused = true;
  }
}
