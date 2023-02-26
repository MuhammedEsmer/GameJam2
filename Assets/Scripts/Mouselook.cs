using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouselook : MonoBehaviour
{
    [Range(50, 500)]
    public float sens;

    public Transform body;
    float xRot;
    bool mousedown = false;
    
  

    private void Update()
    {
      if ((Input.GetMouseButtonDown(1)))
       {
            mousedown= true;
       }
      if ((Input.GetMouseButtonUp(1)))
        {
            mousedown= false;
        }
      if (mousedown)
        {
            MouseMove();
        }
       
        
    }

   void MouseMove()
    {
        float rotX = Input.GetAxisRaw("Mouse X") * sens * Time.deltaTime;
        float rotY = Input.GetAxisRaw("Mouse Y") * sens * Time.deltaTime;

        xRot -= rotY;
        xRot = Mathf.Clamp(xRot, -30f, 30f);
        transform.localRotation = Quaternion.Euler(xRot, 0f, 0f);
        body.Rotate(Vector3.up * rotX);
    }
}
