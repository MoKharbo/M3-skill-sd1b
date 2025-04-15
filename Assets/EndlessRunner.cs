using UnityEngine;

public class EndlessRunner : MonoBehaviour
{
    private Animator _animator;
    Vector3 velocity = Vector3.zero;
    Vector3 acceleration = Vector3.zero;
    float yBegin = -2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _animator.SetBool("Jump", true);
            acceleration = new Vector3(0, -30, 0);
            velocity = new Vector3(0, 10, 0);
        }
        else
        {
            _animator.SetBool("Jump", false);
        }

        if (transform.position.y < yBegin)
        {
            acceleration = Vector3.zero;
            velocity = Vector3.zero;
            transform.position = new Vector3(transform.position.x, yBegin, 0);
        }
        
            velocity += acceleration * Time.deltaTime;
        transform.position += velocity * Time.deltaTime;
    }
}
