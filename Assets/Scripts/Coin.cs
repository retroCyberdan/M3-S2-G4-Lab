using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private static int _coins = 0; // <- la rendo statica per poter essere accessibile universalmente
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            _coins++;
            Debug.Log($"Hai raccolto {_coins} monete");
            gameObject.SetActive(false);
        }
    }
}
