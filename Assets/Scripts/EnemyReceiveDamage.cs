﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyReceiveDamage : MonoBehaviour
{
    // Start is called before the first frame update
    public float maxHealth;
    public float health;

    public GameObject healthBar;
    public Slider healthBarSlider;

    void Start()
    {
        health = maxHealth;
    }
    public void DealDamage(float Damage)
    {
        healthBar.SetActive(true);
        health -= Damage;
        CheckDeath();
        healthBarSlider.value = CalculateHealthPercentage();
    }

    public void HealCharacter(float heal)
    {
        health += heal;
        CheckOverheal();
        healthBarSlider.value = CalculateHealthPercentage();
    }

    private void CheckOverheal()
    {
        if (health > maxHealth)
        {
            health = maxHealth;
        }
    }
    private void CheckDeath()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    private float CalculateHealthPercentage()
    {
        return (health / maxHealth);
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
