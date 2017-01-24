using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField] private bool drawGizmos;
    [SerializeField] private float targetRadius;

    [SerializeField] private LayerMask layer;

    private bool _hasTarget;
    private List<GameObject> _targetsInRange;
    private GameObject _target;

    void Start()
    {
        _targetsInRange = new List<GameObject>();
    }

    void Update()
    {
        Collider[] cols = Physics.OverlapSphere(transform.position, targetRadius);
        _targetsInRange.Clear();

        foreach (Collider col in cols)
        {
            _targetsInRange.Add(col.gameObject);
        }

        if (_hasTarget)
        {
            if (_targetsInRange.Contains(_target))
            {
                //Shoot
            }else {
                _target = null;
                _hasTarget = false;
                //Lost Target
            }
        }else{
            if (_targetsInRange.Count > 0)
            {
                _target = _targetsInRange[0];
                _hasTarget = true;
                //Target is in range
            }
        }    
    }

    void OnDrawGizmos()
    {
        if (drawGizmos)
        Gizmos.DrawWireSphere(new Vector3(transform.position.x, 0f, transform.position.z), targetRadius);

    }
}
