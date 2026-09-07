using UnityEngine;
using UnityEngine.UIElements;

[RequireComponent(typeof(CharacterController))]
public class ProdvonMove : MonoBehaviour
{
    [SerializeField] private float slopeForce = 5f;
    [SerializeField] private float Speed = 5f;
    [SerializeField] private float gravity = -9.81f;
    [SerializeField] private float jumpForce = 8f;
    [SerializeField] private float rotationSpeed = 300f;
    [SerializeField] private float slopeRayLength = 1.5f;
    private CharacterController controller;
    private Vector3 moveDirection = Vector3.zero;
    private void Awake()
    {
        controller = GetComponent<CharacterController>();
    }
    private void Update()
    {
        if (controller.isGrounded)
        {
            SetMoveDiraction();
            if (Input.GetButtonDown("Jump"))
            {
                Jump();
            }
        }
        Rotate();
    }
    private void FixedUpdate()
    {
        Slope();
        moveDirection.y += gravity * Time.fixedDeltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }
    private void SetMoveDiraction()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 inputDirection = new Vector3(horizontal, 0f, vertical);
        inputDirection = transform.TransformDirection(inputDirection);
        moveDirection = inputDirection * Speed;
    }
    private void Jump()
    {
        moveDirection.y += jumpForce;
    }
    private void Rotate()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }

    }
    private void Slope()
    {
        if (Physics.Raycast(transform.position, Vector3.down, out RaycastHit hit, slopeRayLength) == false)
        {
            return;
        }
        if(Vector3.Angle(hit.normal, Vector3.up) > controller.slopeLimit)
        {
            moveDirection.x += (1f- hit.normal.y) * hit.normal.x * slopeForce;
            moveDirection.z += (1f - hit.normal.y) * hit.normal.z * slopeForce;
            moveDirection.y -= slopeForce;


        }
    }
}
