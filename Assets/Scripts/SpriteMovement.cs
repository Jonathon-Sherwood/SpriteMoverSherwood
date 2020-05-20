using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        //multiplies the movementspeed variable to the right vector on the gameobject by time rather than by framerate
        transform.position += Vector3.right * movementSpeed * Time.deltaTime;
    }
}
