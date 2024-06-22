using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] CharacterController characterController;
    [SerializeField] PlayerInput playerInput;
    [SerializeField] GameObject gem;

    [SerializeField] float speed;

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
        vectorInput = playerInput.actions["Move"].ReadValue<Vector2>();

        Vector3 movementInput = new Vector3(vectorInput.x, 0f, vectorInput.y);
        
        characterController.SimpleMove(movementInput * speed);

        characterController.gameObject.transform.LookAt(characterController.gameObject.transform.position + movementInput);

        if (playerInput.actions["Magic"].WasPressedThisFrame())
        {
            GameManager.Instance.CastLight();
        }

    }

}
