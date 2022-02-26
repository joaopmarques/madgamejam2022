using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
  [SerializeField] private Transform followTarget;

  public float enemyDistance = 5.0f;

  private NavMeshAgent agent;

  private void Awake()
  {
    agent = GetComponent<NavMeshAgent>();
  }

  void Update()
  {
    float distance = Vector3.Distance(transform.position, followTarget.transform.position);
    if (distance < enemyDistance)
    {
      agent.SetDestination(followTarget.position);
    }
  }
}
