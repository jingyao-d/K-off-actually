using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;
using UnityEngine.UI;
public class NoteController : MonoBehaviour
{
    [SerializeField] public string note;
    private Vector3 moveVector = new Vector3 (1f,0f,0f);

    void Update()
    {
        transform.position += moveVector;

        if(transform.position.x > 2000)
        {
            Destroy(gameObject);
        }
    }
}
