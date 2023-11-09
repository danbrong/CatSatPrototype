using UnityEngine;

public class PlayerCameraFollow : MonoBehaviour
{
    // Variable Declaration
    public Transform player;
    public float followSpeed;
    public Vector3 offset;

    // Update is called once per frame
    void LateUpdate()
    {
        // Use Late Update to ensure follow after player
        Vector3 desiredPosition = player.position + offset; // Sets initial camera position based off player position
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, followSpeed); // Adjusts Camera Follow behavior

        transform.position = smoothedPosition; // Completes movement of camera
    }
}
