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

    IEnumerator ColorWait() {
        yield return new WaitForSeconds(0.05f);
        mr.material.SetColor("_Color", Color.white);
    }

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

    void OnCollisionEnter(Collision collision) {
        mr.material.SetColor("_Color", colorList[colorSet]);
        if (colorSet == 2) {
            colorSet = 0;
        }  else {
            colorSet++;
        }
    }

    void OnCollisionExit(Collision collision) {
        StartCoroutine(ColorWait());
    }
}
