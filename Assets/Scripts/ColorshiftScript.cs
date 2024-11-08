using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorshiftScript : MonoBehaviour
{

    private Rigidbody rb;
    private MeshRenderer mr;

    private Color[] colorList = {Color.magenta, Color.red, Color.gray};
    private int colorSet = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        mr = GetComponent<MeshRenderer>();
        mr.material.SetColor("_Color", Color.white);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider) {
        mr.material.SetColor("_Color", colorList[colorSet]);
        if (colorSet == 2) {
            colorSet = 0;
        }  else {
            colorSet++;
        }
    }

    void OnTriggerExit(Collider collider) {

    }
}
