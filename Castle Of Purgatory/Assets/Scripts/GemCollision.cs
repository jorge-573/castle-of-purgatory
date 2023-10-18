using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemCollision : MonoBehaviour
{
  PointsHandler pointsHandler;

  // Start is called before the first frame update
  void Start()
  {
    pointsHandler = PointsHandler.singleton;
  }

  void OnTriggerEnter2D(Collider2D other)
  {
    //GetComponent<AudioSource>().Play();
    pointsHandler.AddPoints(1);
    Destroy(this.gameObject);
  }



}

