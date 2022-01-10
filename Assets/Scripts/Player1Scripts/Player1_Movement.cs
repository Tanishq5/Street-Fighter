using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1_Movement : MonoBehaviour
{
    [SerializeField] float Speed = 5f;

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        Vector3 MoveRight = Vector3.forward * Speed * h * Time.deltaTime;

        transform.Translate(MoveRight);

        IdleToMoveForwardAnimation();
        
        IdleToMoveBackwardAnimation();
    }

    private void IdleToMoveForwardAnimation()
    {
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Animator>().SetBool("moveF",true);
        }
        else
        {
            GetComponent<Animator>().SetBool("moveF",false);
        }

    }

    private void IdleToMoveBackwardAnimation()
    {
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Animator>().SetBool("moveB", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("moveB", false);
        }
    }
}