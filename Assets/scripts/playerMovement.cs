using UnityEngine;
using UnityEngine.UIElements;

public class playerMovement : MonoBehaviour
{
    private const string Horizontal = nameof(Horizontal);
    private const string Vertical = nameof(Vertical);

    [SerializeField] private float rotateSpeed;
    [SerializeField] private float moveSpeed;
    void Update()
    {
        Rotate();
        Move();
    }
    void Rotate()
    {
        float rotation = Input.GetAxis(Horizontal);
        transform.Rotate(rotation * rotateSpeed * Time.deltaTime * Vector3.up);
    }
    void Move()
    {
       float direction = Input.GetAxis(Vertical);
        float distance = direction * moveSpeed * Time.deltaTime;
        transform.Translate(Vector3.forward * distance);
    }

    // Update is called once per frame
   
}
