using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private int _coins = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        _coins++;
        Debug.Log($"Hai {_coins} monete");
        collision.gameObject.SetActive(false);
    }
}
