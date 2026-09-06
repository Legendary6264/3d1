using UnityEngine;

public class ConsoLoger : MonoBehaviour
{
    [SerializeField] private Vector3 movementDirection;
    private void Start()
    {
        Debug.Log("This is start");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(movementDirection, Space.World);
    }
}
