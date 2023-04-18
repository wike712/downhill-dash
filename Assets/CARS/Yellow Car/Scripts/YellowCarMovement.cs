using UnityEngine;

public class YellowCarMovement : MonoBehaviour
{
    private Animator animator;
    [SerializeField]
    public float _speed = 3f;
    private float _turn = 0.35f;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void calculateMovement()
    {
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Drive") ^ animator.GetCurrentAnimatorStateInfo(0).IsName("Drive2"))
        {
            Vector3 direction = new Vector3(0f, 0f, 2f);
            transform.Translate(direction * _speed * Time.deltaTime);
            animator.SetBool("Drive", true);
            animator.SetBool("Left", false);
            animator.SetBool("Right", false);
        }

        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Left"))
        {
            Vector3 direction = new Vector3(_turn, 0f, 2f);
            transform.Translate(direction * _speed * Time.deltaTime);
            animator.SetBool("Drive", false);
            animator.SetBool("Left", true);
            animator.SetBool("Right", false);
        }
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Right"))
        {
            Vector3 direction = new Vector3(-_turn, 0f, 2f);
            transform.Translate(direction * _speed * Time.deltaTime);
            animator.SetBool("Drive", false);
            animator.SetBool("Left", false);
            animator.SetBool("Right", true);
        }
    }

    void limitMovement()
    {

        if (transform.position.x >= 0)
        {
            transform.position = new Vector3(0, transform.position.y, transform.position.z);
        }
        if (transform.position.x <= -2)
        {
            transform.position = new Vector3(-2, transform.position.y, transform.position.z);
        }
    }

    void Update()
    {
        calculateMovement();
    }

    void LateUpdate()
    {
        limitMovement();
    }
}