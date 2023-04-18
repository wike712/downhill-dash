using UnityEngine;

public class SilverCoin : MonoBehaviour
{

    public SilverCoinMovement movement;
    public Animator animator;

    void Start()
    {
        movement = GetComponent<SilverCoinMovement>();
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Vee")
        {
            GetComponent<AudioSource>().Play();
            movement.enabled = false;
            animator.SetTrigger("get");
            Invoke("selfDestruct", 2);
        }
    }
    void selfDestruct()
    {
        Destroy(gameObject);
    }
}