using UnityEngine;

public class Follover : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var diraction = (player.position - transform.position).normalized;
        transform.Translate(diraction * speed);
    }
}
