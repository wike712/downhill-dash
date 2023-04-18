using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Animator mAnimator;
    [SerializeField]
    GroundCheck groundCheck;
    public AudioSource roll;
    public float _speed = 4f;

    void Start()
    {
        mAnimator = GetComponent<Animator>();
        groundCheck = GetComponent<GroundCheck>();
    }

    void calculateMovement()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        if (groundCheck.isGrounded == true)
        {
            Vector3 direction = new Vector3(0f, 0f, -horizontalInput);
            transform.Translate(direction * _speed * Time.deltaTime);
        }
        else
        {
            Vector3 direction = new Vector3(0f, 0f, -horizontalInput);
            transform.Translate(direction * _speed * 0.8f * Time.deltaTime);
        }
    }


    void movementAnimations()
    {
        if (Input.GetAxisRaw("Horizontal") != 0)
        {
            if (Input.GetAxisRaw("Horizontal") < 0 && groundCheck.isGrounded == true)
            {
                mAnimator.SetBool("TrLeft", true);
            }
            if (Input.GetAxisRaw("Horizontal") > 0 && groundCheck.isGrounded == true)
            {
                mAnimator.SetBool("TrRight", true);
            }
        }
        else
        {
            mAnimator.SetBool("TrLeft", false);
            mAnimator.SetBool("TrRight", false);
            mAnimator.SetBool("TrIdle", true);
        }
    }

    void soundFX()
    {
        if (groundCheck.isGrounded)
        {
            if (roll.isPlaying == false)
            {
                roll.Play();
            }
            roll.loop = true;
        }
        else
        {
            roll.Stop();
            roll.loop = false;
        }
    }

    void Update()
    {
        calculateMovement();
        movementAnimations();
        soundFX();
    }

    void FixedUpdate()
    {
    }
}
