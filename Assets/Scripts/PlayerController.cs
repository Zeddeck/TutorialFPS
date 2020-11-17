using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed; 
    
    private CharacterController characterController;

    private void Awake()
    {
        //Es lo primero que se ejecuta
        characterController = GetComponent<CharacterController>();

    }

    private void Start()
    {
        
    }


    private void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(x, 0, y);
        movement = movement * playerSpeed * Time.deltaTime;
        movement = transform.rotation * movement;

        characterController.Move(movement);
    }
}
