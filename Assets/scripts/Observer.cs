using UnityEngine;

public class Observer : MonoBehaviour
{
    [SerializeField] private Transform follower;
    

    // Update is called once per frame
    private void Update()
    {
      var diraction = (follower.position - transform.position).normalized;
        transform.forward = diraction;
    }
}
