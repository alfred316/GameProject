using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public PlayerModel player;
    public CharacterController characterController;
    public Camera mainCam;
   

    // Start is called before the first frame update
    void Start()
    {
        player = new PlayerModel();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        //Get the value of the Horizontal input axis.

        float verticalInput = Input.GetAxis("Vertical");
        //Get the value of the Vertical input axis.

        //transform.Translate(new Vector3(horizontalInput, 0, verticalInput) * speed * Time.deltaTime);
        //Move the object to XYZ coordinates defined as horizontalInput, 0, and verticalInput respectively.
        characterController.Move(new Vector3(horizontalInput, 0, verticalInput) * player.movementSpeed * Time.deltaTime);

        
    }
}
