using UnityEngine;

public class PufferfishMove : MonoBehaviour
{
    public float speed = 3f;
    public float detectDistance = 1f;
    public LayerMask wallLayer; // Set this in Inspector

    private Vector3 direction;

    void Start()
    {
        // Move forward based on initial facing direction
        direction = transform.forward;
    }

    void Update()
    {
        // Move in current direction
        transform.position += direction * speed * Time.deltaTime;

        // Check for walls using a raycast
        if (Physics.Raycast(transform.position, direction, detectDistance, wallLayer))
        {
            // Flip direction 180 degrees
            direction = -direction;

            // Rotate to face new direction
            transform.forward = direction;
        }
    }
}