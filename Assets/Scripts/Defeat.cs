using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defeat : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //Destroy(collision.gameObject);
            Debug.Log("Enemigo");
            collision.gameObject.transform.position = new Vector3(0,5,0);
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            //Destroy(collision.gameObject);
            Debug.Log("Defeat...");
            collider.gameObject.transform.position = new Vector3(0, 5, 0);
        }
    }
}
