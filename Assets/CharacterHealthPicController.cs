using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.U2D;
using UnityEngine.UIElements;

public class CharacterHealthPicController : MonoBehaviour
{

  int playerHealth;
  
  GameObject IndexChild(int ind)
  {
    return this.gameObject.transform.GetChild(ind).gameObject;
  }

  void Update()
  {
    playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerLife>().currentHealth;
    // this is some ugly fuckin' code
    if (playerHealth <= 100)
    {
      IndexChild(0).SetActive(true);
      IndexChild(1).SetActive(false);
      IndexChild(2).SetActive(false);
      IndexChild(3).SetActive(false);
    }
    if (playerHealth <= 75)
    {
      IndexChild(0).SetActive(false);
      IndexChild(1).SetActive(true);
      IndexChild(2).SetActive(false);
      IndexChild(3).SetActive(false);
    }
    if (playerHealth <= 50)
    {
      IndexChild(0).SetActive(false);
      IndexChild(1).SetActive(false);
      IndexChild(2).SetActive(true);
      IndexChild(3).SetActive(false);
    }
    if (playerHealth <= 25)
    {
      IndexChild(0).SetActive(false);
      IndexChild(1).SetActive(false);
      IndexChild(2).SetActive(false);
      IndexChild(3).SetActive(true);
    }
  }
}
