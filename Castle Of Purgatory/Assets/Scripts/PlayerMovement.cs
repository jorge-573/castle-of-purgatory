using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
  [SerializeField] Player player;
  void Awake()
  {

  }

  void Update()
  {
    if (Input.GetKey(KeyCode.A))
    {
      player.Move(new Vector3(-1, 0, 0));
    }
    else if (Input.GetKey(KeyCode.D))
    {
      player.Move(new Vector3(1, 0, 0));
    }
    else
    {
      player.Stop();
    }

    if (Input.GetKeyDown(KeyCode.Space))
    {
      player.Jump();
    }
  }
}
