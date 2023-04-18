using UnityEngine;

public class BronzeCoin : MonoBehaviour
{

    public BronzeCoinMovement movement;
    public Animator animator;

    void Start()
    {
        movement = GetComponent<BronzeCoinMovement>();
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