using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{

    public float speed = 5f;
    public float rotationSpeed = 100f;

    // Update is called once per frame
    void Update()
    {
        

        // Rotar el objeto en el eje Z
        //transform.Rotate(new Vector3(0, 0, rotationSpeed) * Time.deltaTime);

        // Move the object to the left
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }

    // This method is called when the object collides with another collider
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the object collided with a "DeathZone" tagged object
        if (collision.CompareTag("DestroyZone"))
        {
            // Destroy the object
            Destroy(gameObject);
        }
    }
}
