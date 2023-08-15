using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMovement : MonoBehaviour
{
    [SerializeField] private float _platformSpeed;
    void Start()
    {
        
    }

    void Update()
    { 
        transform.position += Time.deltaTime * new Vector3(0, 0, -_platformSpeed);
    }
}
