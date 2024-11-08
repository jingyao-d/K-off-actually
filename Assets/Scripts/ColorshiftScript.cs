using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorshiftScript : MonoBehaviour
{

    private Rigidbody rb;
    private MeshRenderer mr;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        mr = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider) {
        mr.material.SetColor("_Color", Color.red);
    }

    void OnTriggerExit(Collider collider) {

    }
}
