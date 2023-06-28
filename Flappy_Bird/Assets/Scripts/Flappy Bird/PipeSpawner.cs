using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public Transform spawnPosition;
    public float delayPerSpawn;

    public float maxHeight;
    public float minHeight;

    private float currentTimeSpawn = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTimeSpawn > delayPerSpawn)
        {
            Vector3 pipePos = new Vector3(3.0f, Random.Range(minHeight, maxHeight), 0.0f);
            currentTimeSpawn = 0;
            // Spawn Pipe
            GameObject pipe = Instantiate(pipePrefab);
            pipe.transform.position = pipePos;
        }
        currentTimeSpawn += Time.deltaTime;
    }
}
