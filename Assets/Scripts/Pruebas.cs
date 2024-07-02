using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pruebas : MonoBehaviour
{
    bool hidden;

    public bool isHidden()
    {
        return hidden;
    }

    private void OnTriggerEnter()
    {
        hidden = true;
        Debug.Log("Usare la posicion del personaje");
    }

    private void OnTriggerExit()
    {
        hidden = false;
        Debug.Log("Usare la posicion del baston");
    }
}
