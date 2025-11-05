using UnityEngine;

public class RotateSprite : MonoBehaviour
{
    [SerializeField]
    private float rotationSpeedDegreesPerSecond = 90f;

    private void Update()
    {
        // Spin around Z so the sprite keeps rotating in 2D
        transform.Rotate(Vector3.forward, rotationSpeedDegreesPerSecond * Time.deltaTime);
    }
}
