using UnityEngine;

public class Jump : MonoBehaviour
{
    private Animator mAnimator;
    [SerializeField]
    private GroundCheck groundCheck;

    public AudioSource jumpp;

    public AudioSource dashh;

    public Rigidbody rb;

    [Range(1, 10)]
    public float jumpVelocity;
    [Range(1, 10)]
    public float dashVelocity;

    void Start()
    {
        mAnimator = GetComponent<Animator>();
        groundCheck = GetComponent<GroundCheck>();
        rb = GetComponent<Rigidbody>();

    }

    void jumpAnimation()
    {
        if (groundCheck.isGrounded == true)
        {
            mAnimator.SetBool("Jumping", false);
        }
        if (groundCheck.isGrounded == false)
        {
            mAnimator.SetBool("Jumping", true);
            mAnimator.SetBool("TrLeft", false);
            mAnimator.SetBool("TrRight", false);
        }

    }

    void jump()
    {
        if (groundCheck.isGrounded == true)
        {
            if (Input.GetButtonDown("Jump"))
            {
                jumpp.Play();
                rb.velocity = Vector3.up * jumpVelocity;
            }
        }
    }


    void dash()
    {
        if (Input.GetAxisRaw("Horizontal") != 0)
        {
            if (Input.GetButtonDown("Dash"))
            {
                if (groundCheck.isGrounded == true)
                {
                    dashh.Play();
                    Vector3 direction = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
                    rb.velocity = direction * dashVelocity;
                }
                else
                {
                    dashh.Play();
                    Vector3 direction = new Vector3(Input.GetAxisRaw("Horizontal"), 0.01f, 0f);
                    rb.velocity = direction * dashVelocity * 0.8f;
                }
            }
        }
    }

    void Update()
    {
        Debug.Log(Input.GetAxisRaw("Horizontal"));
        jumpAnimation();
        jump();
        dash();
    }

}
