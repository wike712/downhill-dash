using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SilverCoinMovement : MonoBehaviour
{
    private float _speed;
    void calculateMovement()
    {
        if (
        FindObjectOfType<GameManager>().gameOver == false)
        {
            _speed = 7;
            Vector3 direction = new Vector3(0f, 0f, -2f);
            transform.Translate(direction * _speed * Time.deltaTime);
        }
    }

    void Update()
    {
        calculateMovement();
    }
}
