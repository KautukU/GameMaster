using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform Player;
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        
        
        this.transform.position = new Vector3(Player.position.x, 0f, -10f);


    }
}
