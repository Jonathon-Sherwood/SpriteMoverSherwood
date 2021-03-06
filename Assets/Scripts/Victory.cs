﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victory : MonoBehaviour
{
    //Allows the designer to specify which object is being deactivated in inspector.
    public GameObject objectToActivate;

    //Constrains designer to only assign game objects with SpriveMovement component in inspector.
    public SpriteMovement componentToDisable;

    public void OnTriggerEnter2D(Collider2D other)
    {
        //When the player reaches the end of the maze they are unable to move and the victory screen appears.
        if (other.gameObject.name == "Player")
        {
            objectToActivate.SetActive(true);
            componentToDisable.enabled = false;
        }
    }
}
