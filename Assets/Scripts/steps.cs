using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class StepsLoop : MonoBehaviour
{
    private FMOD.Studio.EventInstance instance;
    [SerializeField] PlayerInput playerInput;
    bool isplayed = false;

    void Update()
    {
        if (playerInput.actions["Move"].ReadValue<Vector2>().magnitude > 0)
        {
            if (!isplayed)
            {
                isplayed = true;
                instance = FMODUnity.RuntimeManager.CreateInstance("event:/StepsLoop");
                instance.start();
            }
        }
        else
        {
            isplayed = false;
            instance.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
            instance.release();
        }
    }    
}