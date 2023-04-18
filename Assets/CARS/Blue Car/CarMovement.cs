using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public ScoreKeeper scoreKeeper;
    private float _speed;
    void Start()
    {
    }

    void calculateMovement()
    {
        _speed = scoreKeeper.carSpeed;
        Vector3 direction = new Vector3(0f, 0f, 2f);
        transform.Translate(direction * _speed * Time.deltaTime);
    }

    void Update()
    {
        calculateMovement();
    }
}