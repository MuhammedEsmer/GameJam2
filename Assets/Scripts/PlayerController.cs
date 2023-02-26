using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    CharacterController controller;
    Vector3 velocity;
   

    public float speed;
    public float gravity;
 



    private void Start()
    {
        controller= GetComponent<CharacterController>();

    }
    private void Update()
    {
        #region Movement

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 move = transform.right* horizontal+transform.forward * vertical;
        controller.Move(move*speed*Time.deltaTime);

        #endregion

        #region Gravity

        if (velocity.y < 0)
        {
            velocity.y = 0f; 
        }
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        #endregion
    }
}
