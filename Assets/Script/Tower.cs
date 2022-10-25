using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float timeBetweenShots;
    private float nextFire = 0.0F;

    public void Fire(Collider col)
    {
            GameObject g = (GameObject)Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            g.GetComponent<Bullet>().target = col.transform;
    }

    public void OnTriggerStay(Collider col)
    {
        if(col.GetComponent<Monster>() && Time.time > nextFire)
        {
            nextFire = Time.time + timeBetweenShots;
            Fire(col);
        }
    }

}
