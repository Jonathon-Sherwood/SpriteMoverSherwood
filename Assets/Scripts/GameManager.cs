using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Allows the designer to specify which object is being deactivated in inspector.
    public GameObject objectToDeactivate;

    //Constrains designer to only assign game objects with SpriveMovement component in inspector.
    public SpriteMovement componentToDisable;

    // Update is called once per frame
    void Update()
    {
        //Exits out of the program in the final build
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        //Spritemovement attached to gameobject disabled until pressed again
        if (Input.GetKeyDown(KeyCode.P))
        {
            componentToDisable.enabled = !componentToDisable.enabled;
        }
        //Entire gameobject deactivated until pressed again
        if (Input.GetKeyDown(KeyCode.Q))
        {
            objectToDeactivate.SetActive(!objectToDeactivate.activeInHierarchy);
        }

    }
}
