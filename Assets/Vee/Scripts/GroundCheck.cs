using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public bool isGrounded;
    private Collider coll;
    public AudioSource land;

    void Start()
    {
        coll = GetComponent<BoxCollider>();
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Ground")
        {
            land.Play();
            isGrounded = true;
        }
    }

    void OnCollisionExit(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Ground")
        {
            isGrounded = false;
        }
    }
}
