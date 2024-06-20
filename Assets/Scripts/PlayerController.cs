using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody rbPlayer;

    [SerializeField] CharacterController characterController;

    [SerializeField] CastSpell castSpell;

    [SerializeField] float speed;

    Vector3 movementInput;


    void Start()
    {
        rbPlayer = GetComponent<Rigidbody>();

        characterController = GetComponent<CharacterController>();

        castSpell = GetComponent<CastSpell>();
    }


    void Update()
    {
        movementInput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        //rbPlayer.transform.LookAt(movementInput);

        if (Input.GetKeyDown(KeyCode.Space)) { castSpell.Echolocation(); }

        characterController.SimpleMove(movementInput * speed);
    }

    private void FixedUpdate()
    {
       //rbPlayer.MovePosition(rbPlayer.position + movementInput.normalized * speed * Time.fixedDeltaTime);
       

    }



}
