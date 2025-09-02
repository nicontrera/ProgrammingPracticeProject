using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D _rb;
    public CapsuleCollider2D _cd;

    public float xInput;
    public float yInput;


    [SerializeField] private float moveSpeed;
    void Start()
    {

    }

    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _cd = GetComponent<CapsuleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        HandleInput();
        HandleMovement();
    }

    private void HandleInput()
    {
        Debug.Log("calling handle input");
        xInput = Input.GetAxisRaw("Horizontal");
        yInput = Input.GetAxisRaw("Vertical");




    }

    private void HandleMovement()
    {
        Debug.Log("calling handle movement");


        // _rb.linearVelocity = new Vector2(xInput * moveSpeed + platformVelocity.x, _rb.linearVelocityY);
        _rb.linearVelocity = new Vector2(xInput * moveSpeed, _rb.linearVelocityY);

    }
    
    public void Die()
    {
        Destroy(gameObject);
    }
}
