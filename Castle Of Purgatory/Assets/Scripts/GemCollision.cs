using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemCollision : MonoBehaviour
{
  PointsHandler pointsHandler;

  [SerializeField] AudioSource gemPickupSFX;


  // Start is called before the first frame update
  void Start()
  {
    pointsHandler = PointsHandler.singleton;
  }

  void OnTriggerEnter2D(Collider2D other)
  {
    if (other.gameObject.CompareTag("Gem"))
    {
      gemPickupSFX.Play();
      pointsHandler.AddPoints(1);
      Destroy(other.gameObject);
    }

  }



}

