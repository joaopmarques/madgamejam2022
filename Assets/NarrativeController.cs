using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class NarrativeController : MonoBehaviour
{
  public TMP_Text uiTextToDisplay;
  public string currentPlot;

  void Update()
  {
    uiTextToDisplay.text = currentPlot;
  }
}
