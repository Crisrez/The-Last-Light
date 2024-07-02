using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victory : MonoBehaviour
{
    [SerializeField] GameObject M_Victory;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            Debug.Log("VICTORY!!!");
            GameManager.Instance.ActivarMenu(M_Victory);
            //collider.gameObject.transform.position = new Vector3(0, 5, 0);
        }
    }
}
