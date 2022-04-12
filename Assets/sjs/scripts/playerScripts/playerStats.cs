using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerStats : MonoBehaviour, IDamageable<int,float>
{
    public int maxHealth = 5;
    public float pushback = 2;
    //[HideInInspector]
    public int currentHealth;
    public UiManager ui;
    public Rigidbody2D RB;

    private void Start()
    {
        currentHealth = maxHealth;
        RB = this.GetComponent<Rigidbody2D>();
    }
    public void changeHealth(int healthChange, float Xpos)
    {
        currentHealth += healthChange;
        float relativeX = Mathf.Sign(this.transform.position.x-Xpos);
        RB.AddRelativeForce (new Vector2(relativeX, 1) * pushback, ForceMode2D.Impulse);
        
       
        if (currentHealth <= 0)
        {
            
            Destroy(gameObject);
        }
        ui.healthUpdate();
    }
}
