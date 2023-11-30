using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIWindow : MonoBehaviour
{
    public void Show(){
        GetComponent<Canvas>().enabled = true;
    }

    public void Hide(){
        GetComponent<Canvas>().enabled = false;
    }

    public void HidePause(){
        GetComponent<Canvas>().enabled = false;
        Time.timeScale = 1f;
    }
}
