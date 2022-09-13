using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;
    private float spawnRate = 1.50f;

    // Start is called before the first frame update
    void Start()
    {
        // StartCoroutine("SpawnTarget");
        StartCoroutine(SpawnTarget());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnTarget()
    {
        while(true) {
            // Make the method wait some number of seconds..
            yield return new WaitForSeconds(spawnRate);
            // Find a random object from the list of targets
            int index = Random.Range(0, targets.Count);
            // Instantiate the object
            Instantiate(targets[index]);
        }
    }
}
