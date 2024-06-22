using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastSpell : MonoBehaviour
{
    [SerializeField] GameObject spellPrefab;

    [SerializeField] Transform spawnPoint;

    public void Echolocation()
    {
        GameObject.Instantiate(spellPrefab, new Vector3 (spawnPoint.position.x , 1.1f , spawnPoint.position.z), spawnPoint.rotation);
    }

    public void LoadingAnimation(bool activar)
    {
        gameObject.GetComponentInChildren<Animator>().SetBool("Casting", activar);
    }

}
