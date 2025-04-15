using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class PropellerControllerX : MonoBehaviour
{
    private float propellerRotateSpeed = 400.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * propellerRotateSpeed * Time.deltaTime);
    }
}
