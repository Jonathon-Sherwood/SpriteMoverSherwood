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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.up * movementSpeed * Time.deltaTime;
        } else if (!Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= Vector3.up * movementSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.right * movementSpeed * Time.deltaTime;
        }
        else if (!Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= Vector3.right * movementSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            transform.position = new Vector3(0, 0, 0);
        }

    }
}
