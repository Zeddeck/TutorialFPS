using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float playerRotation;
    private void Update()
    {
        float x = Input.GetAxis("Mouse X");

        Vector2 rotate = new Vector2(0, x);
        rotate = rotate * playerRotation * Time.deltaTime;
        transform.Rotate(rotate);
    }
}   
