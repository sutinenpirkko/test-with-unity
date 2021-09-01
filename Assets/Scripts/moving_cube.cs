using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class moving_cube : MonoBehaviour
{
    public Rigidbody CubeRigidBoby;
    public Vector3 jumpForceRight;
    public Vector3 jumpForceLeft;
    public Vector3 jumpForceDown;
    public Vector3 jumpForceUp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("Pelaaja painoi oikealle");
            CubeRigidBoby.AddForce(jumpForceRight);

        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("Pelaaja painoi vasemmalle");
            CubeRigidBoby.AddForce(jumpForceLeft);

        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Pelaaja painoi alas");
            CubeRigidBoby.AddForce(jumpForceDown);

        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Pelaaja painoi ylös");
            CubeRigidBoby.AddForce(jumpForceUp);

        }

    }
}


