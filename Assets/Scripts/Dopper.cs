using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dopper : MonoBehaviour
{
    Rigidbody myRigidbody;
    MeshRenderer meshRenderer;
   [SerializeField] float timeToWait = 5f;


    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        myRigidbody = GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    void Update()
    {
        Falling();
    }

    private void Falling()
    {
        
        if(Time.time >= timeToWait)
        {
            myRigidbody.useGravity = true;
            meshRenderer.enabled = true;
        }
        else
        {
            myRigidbody.useGravity = false;
            meshRenderer.enabled = false;
        }
    }
}
