using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player2_HealthBar : MonoBehaviour
{
    [SerializeField] Player2_Health player2_Health;

    public float CurrentHealth;
    public float maxHealth = 100;

    private Image Player2_Health;
    

    void Start()
    {
        Player2_Health = GetComponent<Image>();
    }

    void Update()
    {
        CurrentHealth = player2_Health.Player2Health;
        Player2_Health.fillAmount = CurrentHealth / maxHealth;
    }
}
