using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog : MonoBehaviour
{

  [TextArea(3, 10)]
  public string plotText = "Change me, change me!";
  
  GameObject narrativeManager;

  // Start is called before the first frame update
  void Start()
  {
    narrativeManager = GameObject.Find("NarrativeManager");

  }

  void OnTriggerEnter(Collider other)
  {
    if (other.gameObject.tag == "Player")
    {
      narrativeManager.GetComponent<NarrativeController>().currentPlot = plotText;
    }
  }

  void OnTriggerExit(Collider other)
  {
    narrativeManager.GetComponent<NarrativeController>().currentPlot = "";
  }
}
