using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldCoinMovement : MonoBehaviour
{
    public ScoreKeeper scoreKeeper;

    private float _speed;
    void calculateMovement()
    {
        if (
        FindObjectOfType<GameManager>().gameOver == false)
        {
            _speed = scoreKeeper.carSpeed;
            Vector3 direction = new Vector3(0f, 0f, -2f);
            transform.Translate(direction * _speed * Time.deltaTime);
        }
    }

    void Start()
    {
        scoreKeeper = GetComponent<ScoreKeeper>();
    }



    void Update()
    {
        calculateMovement();
    }
}
