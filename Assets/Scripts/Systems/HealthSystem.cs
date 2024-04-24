using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    private int health = 100;

    public void Damage(int damage)
    {
        if (health - damage > 0)
        {
            health -= damage;
        }
    }

    public void Heal(int heal)
    {
        if (health < 100)
        {
            health += heal;
        }
    }
}
