using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{

    private GameObject gameControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        GameObject GameControllerObject = GameObject.FindWithTag("Player");

        if (GameControllerObject != null)
        {
            // I got the game controller object!!
            gameControllerScript = GameControllerObject.GetComponent<PlayerController>();
        }
        if (GameControllerObject == null)
        {
            Debug.Log("IT didn't work");
        }
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
