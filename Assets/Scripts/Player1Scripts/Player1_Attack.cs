using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1_Attack : MonoBehaviour
{
    [SerializeField] Transform Player2;

    public float distance;

    public Player2_Health player2_Health;
    public bool player2Hit = false;
    public int ConditionCheck = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GetComponent<Animator>().SetBool("attack", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("attack", false);
        }
        if(ConditionCheck == 1)
        {
            player2Hit = false;
        }
    }

    public void Player1AttackAnimationEvent()
    {
        distance = Vector3.Distance(transform.position, Player2.transform.position);

        ConditionCheck = 0;
        if (distance <= 3.41 && ConditionCheck == 0)
        {
            player2Hit = true;
            player2_Health.Player2Health -= 10;
            ConditionCheck = 1;
        }
    }
}