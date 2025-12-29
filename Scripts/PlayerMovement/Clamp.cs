using UnityEngine;

public class Clamp : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ClampValue();
    }

    void ClampValue()
    {
        float clampedX = Mathf.Clamp(transform.position.x, -9f, 9f);
        float clampedY = Mathf.Clamp(transform.position.y, -16f, 16f);
        transform.position = new Vector3(clampedX, clampedY, transform.position.z);
    }
}
