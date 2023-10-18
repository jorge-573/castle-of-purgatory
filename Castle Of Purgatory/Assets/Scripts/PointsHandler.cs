using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsHandler : MonoBehaviour
{
  [SerializeField] Text pointsText;
  [SerializeField] int numOfPoints = 0;
  public static PointsHandler singleton;

  void Awake()
  {
    if (singleton == null)
    {
      singleton = this;
    }
    else
    {
      Destroy(this.gameObject);
    }
  }

  public void AddPoints(int p)
  {
    numOfPoints += p;
    pointsText.text = numOfPoints.ToString();
    

  }
}
