using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandTrigger : MonoBehaviour
{

  [SerializeField] private Animator animator;

  // Update is called once per frame
  void Update()
  {
    if (Input.GetButtonDown("Fire1"))
    {
      animator.SetBool("playHand", true);
    }
    else
    {
      animator.SetBool("playHand", false);
    }
  }
}
