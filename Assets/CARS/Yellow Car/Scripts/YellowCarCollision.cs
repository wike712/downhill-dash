using UnityEngine;

public class YellowCarCollision : MonoBehaviour
{

    public YellowCarMovement movement;
    private Animator mAnimator;
    GameManager gameManager;

    void Awake()
    {
        gameManager = GetComponent<GameManager>();
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Vee")
        {
            movement.enabled = false;
        }
    }

}
