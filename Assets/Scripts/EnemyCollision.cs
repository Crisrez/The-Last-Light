using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    [SerializeField] GameObject playerPrefab;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Vector3 posInitial = collision.gameObject.GetComponent<PlayerController>().PositionInitial;

            Destroy(collision.gameObject);

            Instantiate(playerPrefab, posInitial,Quaternion.identity);
        }
    }
}
