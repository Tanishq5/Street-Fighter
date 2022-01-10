using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2DamageAnimation : MonoBehaviour
{
    [SerializeField] GameObject Player1;
    [SerializeField] GameObject Player2;

    public Player1_Attack player1_Attack;
    public float distance;
    public bool TriggerAnimation = false;

    public int ConditionCheck2 = 0;

    void Update()
    {
        if(ConditionCheck2 == 1)
        {
            TriggerAnimation = false;
        }
    }
    public void Player2HitAnimation()
    {
        distance = Vector3.Distance(Player1.transform.position,Player2.transform.position);

        ConditionCheck2 = 0;
        if(distance <= 3.14 && player1_Attack.player2Hit == true && ConditionCheck2 == 0)
        {
            TriggerAnimation = true;
            ConditionCheck2 = 1;
        }
    }
}
