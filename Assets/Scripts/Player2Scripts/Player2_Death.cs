using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2_Death : MonoBehaviour
{
    [SerializeField] Player2_Health player2_Health;

    private int Death = 0;

    void Update()
    {
        Player2DeathAnimation();
    }

    private void Player2DeathAnimation()
    {
        if(player2_Health.Player2Health <= 0 && Death == 0)
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