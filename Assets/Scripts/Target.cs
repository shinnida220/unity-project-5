using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody targetRb;
    private float minSpeed = 12;
    private float maxSpeed = 16;
    private float maxTorque = 10;
    private float xRange = 4;
    private float ySpawnPos = -4;


    // Start is called before the first frame update
    void Start()
    {
        // Initialize
        targetRb = GetComponent<Rigidbody>();

        // Add a force to move up
        targetRb.AddForce(RandomForce(), ForceMode.Impulse); // Immediate
        // Add a Torque to rotate the gameObject
        targetRb.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse); // Immediate

        // display at a random position
        transform.position = RandomSpawnPos();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    float RandomTorque()
    {
        return Random.Range(-maxTorque, maxTorque);
    }

    Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(minSpeed, maxSpeed);
    }

    Vector3 RandomSpawnPos()
    {
        return new Vector3(Random.Range(-xRange, xRange), ySpawnPos);
    }

    // When we click on the attached gameObject
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }

    // We have a sensor down the scene that has a trigger
    // Destroy this game object
    void OnTriggerEnter(Collider collider) 
    {
        Destroy(gameObject);
    }
}
