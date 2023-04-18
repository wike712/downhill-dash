using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public ScoreKeeper scoreKeeper;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Car"))
        {
            scoreKeeper.carsDodged = scoreKeeper.carsDodged + 1;
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("Hole"))
        {
            Destroy(other.gameObject);
        }
    }
}
