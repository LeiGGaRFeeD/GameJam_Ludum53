using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform[] _points;

    private int _pointNumber;

    void Start()
    {
        _pointNumber = 0;
    }

    void Update()
    {
        if (transform.position == _points[_pointNumber].position)
        {
            if (_pointNumber + 1 != _points.Length)
                _pointNumber++;
            else
                _pointNumber = 0;

        }
        transform.position = Vector3.MoveTowards(transform.position, _points[_pointNumber].position, _speed);
    }
}