using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastSpell : MonoBehaviour
{
    [SerializeField] GameObject spellPrefab, offset;

    [SerializeField] Transform spawnPoint, pj;

    public void Echolocation()
    {
        if (offset.GetComponent<Pruebas>().isHidden())
        {
            GameObject.Instantiate(spellPrefab, new Vector3(pj.position.x, 1.1f, pj.position.z), pj.rotation);
        }
        else
        {
            GameObject.Instantiate(spellPrefab, new Vector3 (spawnPoint.position.x , 1.1f , spawnPoint.position.z), spawnPoint.rotation);
        }
    }

    public void LoadingAnimation(bool activar)
    {
        gameObject.GetComponentInChildren<Animator>().SetBool("Casting", activar);
    }

    public void LoadingMenu()
    {
        gameObject.GetComponentInChildren<Animator>().SetTrigger("Menu");
    }

}
