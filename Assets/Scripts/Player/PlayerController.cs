using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private CharacterController characterController;
    [SerializeField] private PlayerInput playerInput;
    [SerializeField] private GameObject gem;
    [SerializeField] private float speed;

    private bool iswalking = false;
    private Vector2 vectorInput;

    void Start()
    {
        if (characterController == null)
            characterController = GetComponent<CharacterController>();

        if (playerInput == null)
            playerInput = GetComponent<PlayerInput>();

    }

    void Update()
    {
        if (GameManager.Instance.isGamePaused())
        {
            AudioManager.Instance.PauseSteps();
            return;
        }

        vectorInput = playerInput.actions["Move"].ReadValue<Vector2>();

        Vector3 movementInput = new Vector3(vectorInput.x, 0f, vectorInput.y);
        
        characterController.SimpleMove(movementInput * speed);

        if (vectorInput.magnitude != 0)
        {
            if (!iswalking)
            {
                iswalking = true;
                AudioManager.Instance.PlaySteps();
            }
        }
        else
        {
            iswalking = false;
            AudioManager.Instance.PauseSteps();
        }

        characterController.gameObject.transform.LookAt(characterController.gameObject.transform.position + movementInput);

        if (playerInput.actions["Magic"].WasPressedThisFrame())
        {
            GameManager.Instance.CastLight();
        }

    }

}
