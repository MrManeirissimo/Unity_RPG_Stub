using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempInput : MonoBehaviour
{

	public float speed = 10;
	void Start ()
    {
		
	}
	
	
	void Update ()
    {
	    if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(transform.forward * speed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(transform.forward * speed * -1);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(transform.right * speed * -1);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(transform.right * speed);
        }


        if (Input.GetKey(KeyCode.V))
        {
            FindObjectOfType<CameraFollowComponent>().ChangeCameraOffset(new Vector3(0, 50, -30), true);
        }
        if (Input.GetKey(KeyCode.T))
        {
            FindObjectOfType<CameraFollowComponent>().ChangeCameraOffset(new Vector3(0, 50, -30), false);
        }
    }
}
