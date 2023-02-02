using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject bigEnemyPrefab;
    public GameObject mediumEnemyPrefab;
    public GameObject smallEnemyPrefab;

    private float generatorPosition;
    void Start()
    {
        InvokeRepeating("GenBig", 0, 2.0f);
        InvokeRepeating("GenMedium", 1, 2.0f);
        InvokeRepeating("GenSmall", 1.4f, 2.0f);
    }

    void Update()
    {
        generatorPosition = Random.Range(-0.8f, 0.8f);
    }

    void GenBig()
    {
        var big = Instantiate(bigEnemyPrefab, new Vector3(generatorPosition, 1.7f, 0), this.transform.rotation);
    }
    void GenMedium()
    {
        var medium = Instantiate(mediumEnemyPrefab, new Vector3(generatorPosition, 1.7f, 0), this.transform.rotation);
    }
    void GenSmall()
    {
        var small = Instantiate(smallEnemyPrefab, new Vector3(generatorPosition, 1.7f, 0), this.transform.rotation);
    }


}
