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
            //Destroy(collision.gameObject);
            Debug.Log("Enemigo");
            GameManager.Instance.ActivarMenu(M_Defeat);
            //collision.gameObject.transform.position = new Vector3(0,5,0);
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            //Destroy(collision.gameObject);
            Debug.Log("Defeat...");
            GameManager.Instance.ActivarMenu(M_Defeat);
            //collider.gameObject.transform.position = new Vector3(0, 5, 0);
        }
    }
}
