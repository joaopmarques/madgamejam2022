using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AdvanceStage : MonoBehaviour
{

  public int nextSceneIndex;

  void OnTriggerEnter(Collider other)
  {
    if (other.gameObject.tag == "Player")
    {
      SceneManager.LoadScene(nextSceneIndex);
    }
  }
}
