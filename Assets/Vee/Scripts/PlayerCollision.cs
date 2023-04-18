using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour
{
    public AudioSource triggerCrash;
    public PlayerMovement movement;
    public ScoreKeeper scoreKeeper;
    private Animator animator;
    private Collider coll;
    bool crashed = false;

    void Start()
    {
        animator = GetComponent<Animator>();
        coll = GetComponent<BoxCollider>();
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Car")
        {
            animator.SetBool("TrCarCollision", true);
            onOuch();
        }
        if (collisionInfo.collider.tag == "Hole")
        {
            movement._speed = 0;
            movement.transform.position = collisionInfo.collider.transform.position;
            animator.SetTrigger("TrFall");
            onOuch();
        }
        if (collisionInfo.collider.tag == "GoldCoin")
        {
            collisionInfo.collider.enabled = false;
            scoreKeeper.goldCoin();
        }
        if (collisionInfo.collider.tag == "SilverCoin")
        {
            collisionInfo.collider.enabled = false;
            scoreKeeper.silverCoin();
        }
        if (collisionInfo.collider.tag == "BronzeCoin")
        {
            collisionInfo.collider.enabled = false;
            scoreKeeper.bronzeCoin();
        }
    }


    void onOuch()
    {
        if (crashed == false)
        {
            triggerCrash.Play();
            crashed = true;
        }
        coll.gameObject.GetComponent<Rigidbody>().useGravity = false;
        movement.enabled = false;
        coll.enabled = false;
        animator.SetBool("TrIdle", false);
        animator.SetBool("TrLeft", false);
        animator.SetBool("TrRight", false);
        FindObjectOfType<GameManager>().endGame();
    }
}
