using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float rotateSpeedY = 5f;
    [SerializeField] float rotateSpeedX = 5f;
    [SerializeField] float rotateSpeedZ = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotateSpeedX,rotateSpeedY,rotateSpeedZ);    }
}
