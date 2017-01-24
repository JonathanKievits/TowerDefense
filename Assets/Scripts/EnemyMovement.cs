using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    [SerializeField] private float moveSpeed;

    private Rigidbody rigid;

    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 dir = transform.forward;
        Vector3 vel = dir * moveSpeed * Time.deltaTime;
        rigid.MovePosition(rigid.position + vel);
    }
}
