using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testfall : MonoBehaviour
{
    private Vector2 movementVector;
    private Rigidbody rb2;

    private MeshRenderer mr2;

    [SerializeField] int speed;

    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody>();
        mr2 = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        rb2.velocity = new Vector2(movementVector.x, -5);
    }

    void OnTriggerEnter(Collider collider) {
        Debug.Log("EFEFJdf");
        gameObject.transform.localPosition = new Vector3(-2,6,-2);
    }

    void OnTriggerExit(Collider collider) {

    }
}
