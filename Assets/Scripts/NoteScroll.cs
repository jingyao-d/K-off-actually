using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;
using UnityEngine.UI;

public class NoteScroll : MonoBehaviour
{
    RectTransform rectTransform;
    private Vector3 moveVector = new Vector3 (1,0,0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += moveVector;

        if(transform.position.x > 2000)
        {
            Destroy(gameObject);
        }
    }
}
