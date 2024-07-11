using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defeat : MonoBehaviour
{
    [SerializeField] GameObject M_Defeat;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Enemigo");
            GameManager.Instance.ActivarMenu(M_Defeat);
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            Debug.Log("Defeat...");
            GameManager.Instance.ActivarMenu(M_Defeat);
        }
    }
}
