using UnityEngine;

public class HoverScript : MonoBehaviour
{
    public float hoverHeight = 0.1f; // Adjust this value to control the hover height
    public float hoverSpeed = 1.0f; // Adjust this value to control the hover speed

    void Update()
    {
        // Calculate the hover motion using a sine wave
        float hoverOffset = Mathf.Sin(Time.time * hoverSpeed) * hoverHeight;

        // Apply the offset to the object's Y position
        transform.position = new Vector3(transform.position.x, transform.position.y + hoverOffset, transform.position.z);
    }
}
