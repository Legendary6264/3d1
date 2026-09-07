using UnityEngine;

public class ConsoleLogger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        Debug.LogFormat("Horizontal: {0}, Vertical: {1}", horizontal, vertical);
    }
}
