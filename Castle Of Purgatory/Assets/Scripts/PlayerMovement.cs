using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
  [SerializeField] Player player;
  [SerializeField] Transform body;
  ProjectileThrower projectileThrower;

  void Awake()
  {

  }

  void Update()
  {
    if (Input.GetKey(KeyCode.A))
    {
      player.Move(new Vector3(-1, 0, 0));
      body.localScale = new Vector3(-1, 1, 1);
    }
    else if (Input.GetKey(KeyCode.D))
    {
      player.Move(new Vector3(1, 0, 0));
      body.localScale = new Vector3(1, 1, 1);
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
