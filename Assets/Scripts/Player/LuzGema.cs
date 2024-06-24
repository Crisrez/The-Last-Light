using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuzGema : MonoBehaviour
{
    [SerializeField] int tiempo;

    void Start()
    {
        Time.timeScale = 1;
        GetComponent<CastSpell>().LoadingMenu();
    }

}
