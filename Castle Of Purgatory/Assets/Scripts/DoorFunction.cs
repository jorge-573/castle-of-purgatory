using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DoorFunction : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other){
        if(Input.GetKeyDown(KeyCode.W)){
            SceneManager.LoadScene("MainMenu");

        }
    }
}
