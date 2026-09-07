using UnityEngine;

public class Planet : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Vector3 offset;
    [SerializeField] private Transform rotationCenter;
    void Start()
    {
        offset = transform.position - rotationCenter.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = rotationCenter.position + offset;
        transform.RotateAround(rotationCenter.position, Vector3.up, speed * Time.deltaTime);
        transform.Rotate(Vector3.up* speed * Time.deltaTime);
        offset = transform.position - rotationCenter.position;

    }
}
