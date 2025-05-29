using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField] private int _damage = 5;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.CompareTag("Player"))
        {
            collider.GetComponent<LifeController>().TakeDamage(_damage); // <- accedo alla componente "LifeController" per accedere, di conseguenza, ai suoi metodi
            Destroy(gameObject);
        }
    }
}
