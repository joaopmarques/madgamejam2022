using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimator : MonoBehaviour
{
  [SerializeField] private Animator animator;

  public void Hit()
  {
    animator.SetBool("isHit", true);
  }
}
