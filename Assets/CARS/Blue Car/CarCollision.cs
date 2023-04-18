using UnityEngine;

public class CarCollision : MonoBehaviour
{

    public CarMovement movement;
    GameManager gameManager;

    void Awake()
    {
        movement = GetComponent<CarMovement>();
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Vee")
        {
            movement.enabled = false;
        }
    }

}
