using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    private int health = 100;
    [SerializeField]
    public TMP_Text healthText;

    public void Damage(int damage)
    {
        if (health - damage > 0)
        {
            health -= damage;
            healthText.text = "Health: " + health;
        }
    }

    public void Heal(int heal)
    {
        if (health < 100)
        {
            health += heal;
            healthText.text = "Health: " + health;
        }
    }
}
