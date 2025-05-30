using UnityEngine;

public class MovePipe : MonoBehaviour
{
    public float moveSpeed = 5;
    public float dead_zone = -45;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed * Time.deltaTime);
        if (transform.position.x < dead_zone)
        {
            Destroy(gameObject);
        }
    }
}
