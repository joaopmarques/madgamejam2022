using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
  [SerializeField] private Transform followTarget;

  public float enemyDistance = 30.0f;
  public float stopDistance = 3.0f;

  private NavMeshAgent agent;

  private void Awake()
  {
    agent = GetComponent<NavMeshAgent>();
  }

  void Update()
  {
    float distance = Vector3.Distance(transform.position, followTarget.transform.position);

    // If the enemy is in radius but not too close to push the player
    if (distance < enemyDistance && distance > stopDistance)
    {
      agent.SetDestination(followTarget.position);
    }
  }
}
