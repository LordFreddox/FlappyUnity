using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    private float timer;
    public float maxTime = 1.5f, heightRange = 0.45f;
    public GameObject pipe;
    void Start()
    {
        SpawnPipe();
    }
    private void Update()
    {
        if (timer>maxTime)
        {
            SpawnPipe();
            timer = 0;
        }
        timer += Time.deltaTime;
    }

    private void SpawnPipe()
    {
        Vector3 spawnPos = transform.position + new Vector3(0,Random.Range(-heightRange,heightRange));
        pipe = Instantiate(pipe,spawnPos,Quaternion.identity);

        Destroy(pipe, 10f);
    }    
}
