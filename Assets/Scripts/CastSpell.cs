using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastSpell : MonoBehaviour
{
    [SerializeField] GameObject spell;

    [SerializeField] Transform spawnPoint;

    public void Echolocation()
    {
        GameObject.Instantiate(spell, spawnPoint);
    }

}
