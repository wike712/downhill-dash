using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSound : MonoBehaviour
{
    public AudioSource sound;
    public ScoreKeeper scoreKeeper;

    void calculateMovement()
    {
        Vector3 direction = new Vector3(0f, 0f, -2f);
        transform.Translate(direction * scoreKeeper.carSpeed * Time.deltaTime);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Vee"))
        {
            Debug.Log("ok");
            sound.Play();
        }

    }

    void FixedUpdate()
    {
        calculateMovement();
        if (transform.position.z < -10)
        {
            Destroy(gameObject);
        }
    }
}
