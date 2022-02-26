using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class StatsController : MonoBehaviour
{
  public TMP_Text uiHealth;
  public string currentHealth;

  void Update()
  {
    uiHealth.text = currentHealth;
  }
}
