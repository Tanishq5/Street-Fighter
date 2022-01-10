using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2_Attack : MonoBehaviour
{
    [SerializeField] Transform Player1;

    private float distance2;

    public Player1_Health player1_Health;
    public Player2DamageAnimation player2DamageAnimation;

    void Update()
    {
        Player2Attack();
        //Player2TakeDamageAnimation();
    }

    private void Player2Attack()
    {
        if (Input.GetKeyDown(KeyCode.Joystick1Button2))
        {
            GetComponent<Animator>().SetBool("attack", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("attack", false);
        }
    }

    public void Player2AttackAnimationEvent()
    {
        distance2 = Vector3.Distance(transform.position, Player1.transform.position);

        if(distance2 <= 3.14)
        {
            player1_Health.player1Health -= 10;
        }
    }

    public void Player2TakeDamageAnimation()
    {
        if (player2DamageAnimation.TriggerAnimation == true )
        {
            Debug.Log("Animation Started");
            GetComponent<Animator>().SetBool("taking punch2", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("taking punch2", false);
        }
    }
}
