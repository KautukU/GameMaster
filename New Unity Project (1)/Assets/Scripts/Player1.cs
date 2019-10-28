using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player1 : MonoBehaviour
{

    // Private variables
    private Rigidbody2D rBody;
    public float speed;
    public int extraJumps;

    public float jumpForce;

    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow) && extraJumps>0)
        {
            rBody.velocity = Vector2.up * jumpForce;
            extraJumps--;
        }

    
    }

    // Update is called once per frame
    //FixedUpdate is used when modifying physics values
    void FixedUpdate()
    {
        float inputX = Input.GetAxis("Horizontal");

        rBody.velocity = new Vector2(inputX * speed, rBody.velocity.y);


        //Debug.Log("Horizontal:" + horiz + "Vertical" + vert);



    }
}
