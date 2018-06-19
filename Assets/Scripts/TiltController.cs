using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltController : MonoBehaviour {
    public float maxTilt;

    private float xRot;
    private float zRot;

	// Use this for initialization
	void Start () {
        xRot = 0.0f;
        zRot = 0.0f;
    }

    void LateUpdate()
    {
        float moveHorizontal =  Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");


        if (xRot > maxTilt)
        {
            moveVertical = maxTilt - xRot;
        }
        else if (xRot < (-1 * maxTilt))
        {
            moveVertical = (-1 * maxTilt) - xRot;
        }
        xRot += moveVertical;

        if (zRot > maxTilt)
        {
            moveHorizontal = maxTilt - zRot;
        }
        else if (zRot < (-1 * maxTilt))
        {
            moveHorizontal = (-1 * maxTilt) - zRot;
        }
        zRot += moveHorizontal;

        Vector3 movement = new Vector3(moveVertical, 0.0f, -moveHorizontal);

        transform.Rotate(movement * 0.25f);
    }
}
