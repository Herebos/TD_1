using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject monsterPrefab;

    public float interval = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void LaunchWave()
    {
        InvokeRepeating("SpawnNext", interval, interval);
    }

    void SpawnNext()
    {
        Vector3 newPos = new Vector3(0, 0.5f, 0);
        Instantiate(monsterPrefab, transform.position, Quaternion.AngleAxis(90, newPos));
    }

}
