using UnityEngine;
using UnityEngine.InputSystem;



public class movement : MonoBehaviour

{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Rigidbody rb;
    private Vector3 moveInput;
    private float moveSpeed = 10f;
    public InputActionReference ma;
    private void Awake()
    {
        rb=GetComponent<Rigidbody>();
    }
    private void OnEnable()
    {
        ma.action.Enable();
    }
    private void OnDisable() 
    {
        ma.action.Disable();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveInput=ma.action.ReadValue<Vector2>();
    }
    private void FixedUpdate() {
        rb.linearVelocity= new Vector3(moveInput.x * moveSpeed ,rb.linearVelocity.y, moveInput.z * moveSpeed);
        
    }
}
