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
        /*if (Input.GetKeyDown(KeyCode.W))
        {
            instance = FMODUnity.RuntimeManager.CreateInstance("event:/StepsLoop");
            instance.start();
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            instance.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
            instance.release();
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            instance = FMODUnity.RuntimeManager.CreateInstance("event:/StepsLoop");
            instance.start();
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            instance.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
            instance.release();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            instance = FMODUnity.RuntimeManager.CreateInstance("event:/StepsLoop");
            instance.start();
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            instance.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
            instance.release();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            instance = FMODUnity.RuntimeManager.CreateInstance("event:/StepsLoop");
            instance.start();
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            instance.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
            instance.release();
        }*/

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