using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{

    public float playerspeed = 5f;


    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, playerspeed * Time.deltaTime, Space.Self);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -playerspeed * Time.deltaTime, Space.Self);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-playerspeed * Time.deltaTime, 0, 0, Space.Self);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(playerspeed * Time.deltaTime, 0, 0, Space.Self);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(-Vector3.up * 80 * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up * 80 * Time.deltaTime);
        }
    }



}
