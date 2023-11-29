using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
  [SerializeField] PlayerMovement player;
  [SerializeField] Transform body;
  [SerializeField] AnimationStateChanger animationStateChanger;

  void Awake()
  {

  }

  void FixedUpdate()
  {
    if (Input.GetKey(KeyCode.A))
    {
      player.Move(new Vector3(-1, 0, 0));
      body.localScale = new Vector3(-1, 1, 1);
      animationStateChanger.ChangeAnimationState("Walk", 1);

    }
    else if (Input.GetKey(KeyCode.D))
    {
      player.Move(new Vector3(1, 0, 0));
      body.localScale = new Vector3(1, 1, 1);
      animationStateChanger.ChangeAnimationState("Walk", 1);

    }
    else
    {
      player.Stop();
      animationStateChanger.ChangeAnimationState("Idle", 1);
    }


  }

  void Update()
  {
    if (Input.GetKeyDown(KeyCode.Space))
    {
      player.Jump();
    }
  }
}
