using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    [SerializeField] private GameObject enemy;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spawn();
        }
    }

    void spawn()
    {
        Vector3 spawnPos = new Vector3(transform.position.x, enemy.transform.position.y,transform.position.z);
        GameObject e = Instantiate(enemy, spawnPos, Quaternion.identity) as GameObject;
        e.transform.SetParent(transform);
    }
}
