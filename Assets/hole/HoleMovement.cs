using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleMovement : MonoBehaviour
{
    [SerializeField]
    private float _speed = 7f;

    void calculateMovement()
    {
        if (
        FindObjectOfType<GameManager>().gameOver == false)
        {
            Vector3 direction = new Vector3(0f, 0f, -2f);
            transform.Translate(direction * _speed * Time.deltaTime);
        }
    }

    void Update()
    {
        calculateMovement();
    }
}