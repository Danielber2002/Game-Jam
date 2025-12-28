using UnityEngine;

public class Destructor : MonoBehaviour
{
    public float limiteY = -30f; 

    void Update()
    {
      
        if (transform.position.y < limiteY)
        {
            Destroy(gameObject); 
        }
    }
}