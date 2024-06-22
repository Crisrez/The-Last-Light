using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victory : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            //Destroy(collision.gameObject);
            Debug.Log("VICTORY!!!");
            collider.gameObject.transform.position = new Vector3(0, 5, 0);
        }
    }
}
