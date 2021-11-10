using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseControllingScript : MonoBehaviour
{
    private float mouseX;
    private float mouseY;
    private float rotateAngle=300;
    private Quaternion currentRotation;
    private float speedToreturn = 100f;

    private void Awake()
    {
        currentRotation = transform.rotation;

    }
    void Update()
    {
        // Camera View change
        if (Input.GetKey(KeyCode.Mouse0))
            {
            MouseDrag();
        }
        else if(transform.rotation!=currentRotation )
        {
            transform.rotation = Quaternion.Slerp(transform.rotation,currentRotation,0.03f);
        }
       
    }
   void  MouseDrag()
    {
        mouseX = Input.GetAxis("Mouse X")*rotateAngle*Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y")* rotateAngle * Time.deltaTime;
       transform.RotateAround(transform.position, Vector3.up, -mouseX);// y axis is fixed 
       transform.RotateAround(transform.position, Vector3.right, -mouseY);// x axis is fixed and  object is rotating around the x axis
    }
}
