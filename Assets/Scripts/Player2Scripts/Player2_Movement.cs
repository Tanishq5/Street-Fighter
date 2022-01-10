using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2_Movement : MonoBehaviour
{
    [SerializeField] float Speed = 5f;

    public Vector3 MoverRight;

    void Update()
    {
        float JH = Input.GetAxis("LeftJoystickH");
        MoverRight = Vector3.forward * Speed * JH * Time.deltaTime;

        transform.Translate(MoverRight);

        MoveForwardAnimation();
        MoveBackwardAnimation();
    }

    public void MoveForwardAnimation()
    {
        if (MoverRight.z < 0)
        {
            GetComponent<Animator>().SetBool("moveF", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("moveF", false);
        }
    }

    private void MoveBackwardAnimation()
    {
        if(MoverRight.z > 0)
        {
            GetComponent<Animator>().SetBool("moveB", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("moveB", false);
        }
    }
}
