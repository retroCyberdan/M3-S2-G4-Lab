using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LifeController : MonoBehaviour
{
    public int health;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        if (health <= 0)
        {
            Debug.Log($"Il giocatore è stato sconfitto");
            Destroy(gameObject);
        }
        health -= damage;
        Debug.Log($"{gameObject.name} subisce {damage} danni (HP: {health})");
    }

    public void TakeHeal(int amount)
    {
        if (health <= 0)
        {
            Debug.Log($"Il giocatore è statpo sconfitto");
            Destroy(gameObject);
        }
        health += amount;
        Debug.Log($"{gameObject.name} guadagna {amount} HP (HP: {health})");
    }
}
