using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerStats : MonoBehaviour, IDamageable<int>
{
    public int maxHealth = 5;
    //[HideInInspector]
    public int currentHealth;
    public UiManager ui;

    private void Start()
    {
        currentHealth = maxHealth;
    }
    public void changeHealth(int healthChange)
    {
        currentHealth += healthChange;
        if (currentHealth <= 0)
        {
            
            Destroy(gameObject);
        }
        ui.healthUpdate();
    }
}
