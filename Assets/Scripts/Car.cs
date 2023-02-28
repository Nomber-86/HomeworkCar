using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private float _speed;
    

    // Update is called once per frame
    void Update()
    {
        
        var position = transform.position;
        var step = _speed + Time.deltaTime;
        
        

        if (Input.GetKey(KeyCode.W))
        {
            position.z += step;
        }
        if (Input.GetKey(KeyCode.S))
        {
            position.z -= step;
        }
        if (Input.GetKey(KeyCode.D))
        {
            position.x += step;
        }
        if (Input.GetKey(KeyCode.A))
        {
            position.x -= step;
        }
        
        transform.position = position;
        
    }
}
