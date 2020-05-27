using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The SpriteMovement class moves the game object it is attached to.
/// </summary>

public class SpriteMovement : MonoBehaviour
{
    //allows the designer to adjust the speed of the gameobjects movement speed in the inspector
    public float movementSpeed = 0.1f;

    // Update is called once per frame
    void Update()
    {
        //calls each movement function every frame for player input
        VerticalMovement();
        HorizontalMovement();
        ResetToOrigin();
    }

    /// <summary>
    /// Moves gameobject left or right depending on left or right arrow keys
    /// </summary>
    public void VerticalMovement()
    {
        //Only allows gameobject to move upward if player is not also holding down
        if (Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.DownArrow))
        {
            //moves gameobject upwards based on movementspeed
            transform.position += Vector3.up * movementSpeed * Time.deltaTime;
        }
        //Only allows gameobject to move downward if player is not also holding up
        else if (!Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.DownArrow))
        {
            //moves gameobject downwards based on movementspeed
            transform.position -= Vector3.up * movementSpeed * Time.deltaTime;
        }
    }

    /// <summary>
    /// Moves gameobject up or down depending on up or down arrow keys
    /// </summary>
    public void HorizontalMovement()
    {
        //Only allows gameobject to move to the right if player is not also holding left
        if (Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.LeftArrow))
        {
            //moves gameobject right based on movementspeed
            transform.position += Vector3.right * movementSpeed * Time.deltaTime;
        }
        //Only allows gameobject to move to the left if player is not also holding right
        else if (!Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.LeftArrow))
        {
            //moves gameobject left based on movementspeed
            transform.position -= Vector3.right * movementSpeed * Time.deltaTime;
        }
    }

    /// <summary>
    /// Returns gameobject to origin of scene when space key is pressed
    /// </summary>
    public void ResetToOrigin()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position = new Vector3(0, 0, 0);
        }
    }
}
