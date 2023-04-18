using UnityEngine;

public class GoldCoin : MonoBehaviour
{

    public GoldCoinMovement movement;
    public Animator animator;

    void Start()
    {
        movement = GetComponent<GoldCoinMovement>();
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