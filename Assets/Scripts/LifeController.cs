using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LifeController : MonoBehaviour
{
    [SerializeField] private int health = 20;

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
        health -= damage;
        if (health <= 0)
        {
            Debug.Log($"Il giocatore è stato sconfitto");
            Destroy(gameObject);
        }
        Debug.Log($"{gameObject.name} subisce {damage} danni (HP: {health})");
    }

    public void TakeHeal(int amount)
    {
        health += amount;
        Debug.Log($"{gameObject.name} guadagna {amount} HP (HP: {health})");
    }
}
