using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Tooltip("Time in seconds for a full day cycle")]
    public float dayDuration = 120f; // Default to 2 minutes per full cycle

    private float rotationSpeed;

    void Start()
    {
        // Calculate degrees per second for a full 360-degree rotation
        rotationSpeed = 360f / dayDuration;
    }

    void Update()
    {
        // Rotate the light around the X-axis to simulate the sun moving
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}
