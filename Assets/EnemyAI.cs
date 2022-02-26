using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class EnemyAI : MonoBehaviour
{

  private Vector3 startingPosition;
  private Vector3 roamPosition;

  private void Start()
  {
    startingPosition = transform.position;
  }

  private Vector3 GetRoamingPosition()
  {
    return startingPosition + UtilsClass.GetRandomDir() * Random.Range(5f, 7f);
  }

  // Update is called once per frame
  void Update()
  {

  }
}
