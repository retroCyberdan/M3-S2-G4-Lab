using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Rigidbody2D _rb;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>(); // <- nello Start assengo la componente Rigidbody2D alla variabile "_rb"
    }

    // Update is called once per frame
    // uso il FixedUpdate per gestire la fisica
    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        if(h != 0 || v != 0)
        {
            Vector2 dir = new Vector3(h, v, 0);
            
            float length = dir.magnitude;

            if (length > 1)
            {
                //dir.Normalize(); // <- normalizza il vettore direzione tramite funzione

                dir /= length; // <- normalizza il vettore manualmente
            }

            _rb.MovePosition(_rb.position + dir * (_speed * Time.deltaTime)); // <- muovo il player tramite componente Rigidbody2D
        }
    }
}
