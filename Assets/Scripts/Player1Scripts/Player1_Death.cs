using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1_Death : MonoBehaviour
{
    public Player1_Health player1_Health;

    private int Death = 0;

    void Update()
    {
        Player1DeathAnimation();
    }

    private void Player1DeathAnimation()
    {
        if(player1_Health.player1Health <= 0 && Death == 0)
        {
            Death = 1;
            GetComponent<Animator>().SetBool("death", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("death", false);
        }
    }
}