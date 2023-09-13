using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{ private CharacterController characterController;

    public bool isPowered;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        isPowered = false;
    }


    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));

        if (move != Vector3.zero)
        {
            // Rotate the character to face the movement direction
            transform.LookAt(transform.position + move);
        }
        
        characterController.Move(move*Time.deltaTime*speed);
    }

}
