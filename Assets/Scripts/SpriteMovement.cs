using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The SpriteMovement class moves the game object it is attached to.
/// </summary>
public class SpriteMovement : MonoBehaviour
{
    //Allows the designer to adjust the speed of the gameobjects movement speed in the inspector.
    public float movementSpeed = 0.1f;

    //Allows the designer to specify which object's animator is being called.
    public Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Calls each movement function every frame for player input.
        VerticalMovement();
        HorizontalMovement();
        ResetToOrigin();
    }

    /// <summary>
    /// Moves game object left or right depending on left or right arrow keys.
    /// </summary>
    public void VerticalMovement()
    {
        //Only allows gameobject to move upward if player is not also holding down.
        if (Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.DownArrow))
        {
            //When holding left shift, only a single input from arrows will move the game object a single meter in game space.
            if (Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.UpArrow))
            {
                transform.position += Vector3.up;
            }
            else if (!Input.GetKey(KeyCode.LeftShift))
            {
                //Moves gameobject upwards based on movementspeed.
                transform.position += Vector3.up * movementSpeed * Time.deltaTime;
            }
            //When the sprite is moving, the animation starts moving
            anim.SetBool("Moving", true);
        }
        //Only allows gameobject to move downward if player is not also holding up.
        else if (!Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.DownArrow))
        {
            //When holding left shift, only a single input from arrows will move the game object a single meter in game space.
            if (Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.DownArrow))
            {
                transform.position -= Vector3.up;
            }
            else if (!Input.GetKey(KeyCode.LeftShift))
            {
                //Moves gameobject downwards based on movementspeed.
                transform.position -= Vector3.up * movementSpeed * Time.deltaTime;
            }
            //When the sprite is moving, the animation starts moving
            anim.SetBool("Moving", true);
        } else
        {
            //When the sprite stops moving, the animation should stop moving. This is true regardless of direction.
            anim.SetBool("Moving", false);
        }
    }

    /// <summary>
    /// Moves gameobject up or down depending on up or down arrow keys.
    /// </summary>
    public void HorizontalMovement()
    {
        //Only allows gameobject to move to the right if player is not also holding left.
        if (Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.LeftArrow))
        {
            //When holding left shift, only a single input from arrows will move the game object a single meter in game space.
            if (Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.RightArrow))
            {
                transform.position += Vector3.right;
            }
            else if (!Input.GetKey(KeyCode.LeftShift))
            {
                //Moves gameobject to the right based on movementspeed.
                transform.position += Vector3.right * movementSpeed * Time.deltaTime;
            }
            //When the sprite is moving, the animation starts moving
            anim.SetBool("Moving", true);
        }
        //Only allows gameobject to move to the left if player is not also holding right.
        else if (!Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.LeftArrow))
        {
            //When holding left shift, only a single input from arrows will move the game object a single meter in game space.
            if (Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.LeftArrow))
            {
                transform.position -= Vector3.right;
            }
            else if (!Input.GetKey(KeyCode.LeftShift))
            {
                //Moves gameobject tot he left based on movementspeed.
                transform.position -= Vector3.right * movementSpeed * Time.deltaTime;
            }
            //When the sprite is moving, the animation starts moving
            anim.SetBool("Moving", true);
        }
    }

    /// <summary>
    /// Returns gameobject to origin of scene when space key is pressed.
    /// </summary>
    public void ResetToOrigin()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position = new Vector3(0, 0, 0);
        }
    }
}
