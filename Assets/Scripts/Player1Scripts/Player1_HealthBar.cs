using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1_HealthBar : MonoBehaviour
{
    [SerializeField] Player1_Health player1_Health; 

    public float CurrentHealth;
    public float MaxHeath = 100f;

    private Image Player1_Healthbar;

    void Start()
    {
        Player1_Healthbar = GetComponent<Image>();
    }

    void Update()
    {
        CurrentHealth = player1_Health.player1Health;
        Player1_Healthbar.fillAmount = CurrentHealth / MaxHeath;
    }
}
