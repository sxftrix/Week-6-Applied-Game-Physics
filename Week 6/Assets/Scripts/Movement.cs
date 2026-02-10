using System.Security.Principal;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] public float speed = 2f;

    private Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        var velocity = Vector3.forward * Input.GetAxis("Vertical") * speed;
        transform.Translate(velocity * Time.deltaTime);
        animator.SetFloat("speed", velocity.magnitude);
    }
}
