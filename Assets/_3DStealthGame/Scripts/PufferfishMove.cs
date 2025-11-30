using UnityEngine;

public class PufferfishMove : MonoBehaviour
{
    public float speed = 3f;
    public float detectDistance = 1f;
    public LayerMask wallLayer; // Set this in Inspector

    private Vector3 direction;

    void Start()
    {
        direction = transform.forward;
    }

    void Update()
    {
        transform.position += direction * speed * Time.deltaTime;

        if (Physics.Raycast(transform.position, direction, detectDistance, wallLayer))
        {
            direction = -direction;

            transform.forward = direction;
        }
    }
}