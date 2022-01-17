using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class EnemyMove : MonoBehaviour
{
  private NavMeshAgent _agent;
  // Start is called before the first frame update
  void Start()
  {
    _agent = GetComponent<NavMeshAgent>();
  }

  public void OnDetectObject(Collider collider)
  {
    if (collider.CompareTag("Player"))
    {
      _agent.destination = collider.transform.position;
    }
  }
}
