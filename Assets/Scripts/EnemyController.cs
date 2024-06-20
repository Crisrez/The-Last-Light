using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.AI;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    [SerializeField] NavMeshAgent enemy;

    [SerializeField] GameObject player;

    [SerializeField] GameObject playerPrefab;

    void Update()
    {
        enemy.destination = player.transform.position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Vector3 posInitial = collision.gameObject.GetComponent<PlayerController>().PositionInitial;

            Destroy(collision.gameObject);

            player = Instantiate(playerPrefab, posInitial, Quaternion.identity);
        }
    }
}
