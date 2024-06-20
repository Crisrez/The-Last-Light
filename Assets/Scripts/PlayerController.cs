using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] CharacterController characterController;

    [SerializeField] CastSpell castSpell;

    [SerializeField] PlayerInput playerInput;

    [SerializeField] float speed, cooldown;

    [SerializeField] Vector3 positionInitial;

    public Vector3 PositionInitial { get { return positionInitial; } }

    float timer;

    Vector2 vectorInput;


    void Start()
    {
        characterController = GetComponent<CharacterController>();
        castSpell = GetComponent<CastSpell>();
        playerInput = GetComponent<PlayerInput>();

        positionInitial = gameObject.transform.position;

        timer = 5;
    }

    void Update()
    {
        timer += Time.deltaTime;

        vectorInput = playerInput.actions["Move"].ReadValue<Vector2>();

        Vector3 movementInput = new Vector3(vectorInput.x, 0f, vectorInput.y);
        
        characterController.SimpleMove(movementInput * speed);

        characterController.gameObject.transform.LookAt(characterController.gameObject.transform.position + movementInput);

        if (playerInput.actions["Magic"].WasPressedThisFrame() && timer > cooldown)
        {
            castSpell.Echolocation();
            timer = 0;
        }

    }

}
