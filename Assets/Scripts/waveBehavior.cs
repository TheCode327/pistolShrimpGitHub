using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waveBehavior : MonoBehaviour
{
    public float spawnedTime;
    public float spawnRate;
    public float theta;
    public float r;
    public GameObject diverPrefab;
    public List<GameObject> divers;
    // Start is called before the first frame update
    void Start()
    {
        spawnedTime = 0.0f;
        spawnRate = 5.0f;


    }

    // Update is called once per frame
    void Update()
    {
        if (spawnedTime + spawnRate < Time.time)
        {
            spawnedTime = Time.time;
            theta = UnityEngine.Random.Range(0, 2*Mathf.PI);
            r = UnityEngine.Random.Range(50, 100);
            divers.Add(Instantiate(diverPrefab, new Vector3(r*MathF.Cos(theta), 2, r * MathF.Sin(theta)), new Quaternion(0, 0, 0, 0)));
        }
    }
}
