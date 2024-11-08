using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testfall : MonoBehaviour
{
    private Vector2 movementVector;
    private Rigidbody rb2;

    private MeshRenderer mr2;

    [SerializeField] int speed = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody>();
        mr2 = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().velocity = new Vector2(speed * movementVector.x, GetComponent<Rigidbody>().velocity.y);
    }

    void OnCollisionEnter(Collision collision) {
        //transform.localPosition.y = 6;
    }

    void OnCollisionExit(Collision collision) {

    }
}
