using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnManager : MonoBehaviour
{

    public GameObject obstaclePrefab;
    public Vector3 spawnPos = new Vector3(0, 0, 30);
    public float randomY;
    private float randomRange = 10;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", 0.5f, 5);




    }

    // Update is called once per frame
    void Update()
    {


        






    }
    
    void SpawnObstacle()
    {

        randomY = Random.Range(-randomRange, randomRange);

        spawnPos = new Vector3(0, randomY, spawnPos.z + 50f);

        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);



    }

    
}
