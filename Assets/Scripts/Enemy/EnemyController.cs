using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.AI;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    [SerializeField] NavMeshAgent enemy;

    [SerializeField] GameObject player;

    void Update()
    {
        enemy.destination = player.transform.position;

        if (GameManager.Instance.GetTimer() < 2)
        {
            enemy.speed = 2.5f;
        }
        else
        {
            enemy.speed = 1.5f;
        }
    }

}
