using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _prefab;

    private void Awake()
    {
        Instantiate(_prefab, new Vector3(0, 0, 0), Quaternion.Euler(0, 0, 0));
    }
}
