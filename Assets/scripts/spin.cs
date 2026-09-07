using UnityEngine;

public class spin : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        transform.rotation *= Quaternion.Euler(0, 10, 1);
    }
}
