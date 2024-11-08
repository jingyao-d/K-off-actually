using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputDetection : MonoBehaviour
{
    GameObject[] notes;
    [SerializeField] public int score;
    [SerializeField] GameObject m_S;
    [SerializeField] GameObject m_D;
    [SerializeField] GameObject m_F;
    [SerializeField] GameObject m_J;
    [SerializeField] GameObject m_K;
    [SerializeField] GameObject m_L;
    private Vector3 scaleChange = new Vector3(0.0f, 1.0f, 0.0f);

    private void Start()
    {
        score = 0;
    }

    void Update()
    {
        notes = GameObject.FindGameObjectsWithTag("Note");
    }
    public void OnS()
    {
        StartCoroutine(BlockCoroutine(m_S));

        for(int i = 0; i < notes.Length; i++)
        {
            NoteController noteController = notes[i].GetComponent<NoteController>();
            
            if(noteController.note == "S")
            {
                int notePositionX = (int)notes[i].transform.position.x;

                if(notePositionX > 1750 && notePositionX < 1800)
                {
                    Debug.Log("Note Pressed Successfully");
                    score++;
                    Destroy(notes[i]);
                }
            }
        }
    }
    public void OnD()
    {
        StartCoroutine(BlockCoroutine(m_D));

        for(int i = 0; i < notes.Length; i++)
        {
            NoteController noteController = notes[i].GetComponent<NoteController>();
            
            if(noteController.note == "D")
            {
                int notePositionX = (int)notes[i].transform.position.x;

                if(notePositionX > 1750 && notePositionX < 1800)
                {
                    Debug.Log("Note Pressed Successfully");
                    score++;
                    Destroy(notes[i]);
                }
            }
        }
    }
    public void OnF()
    {
        StartCoroutine(BlockCoroutine(m_F));

        for(int i = 0; i < notes.Length; i++)
        {
            NoteController noteController = notes[i].GetComponent<NoteController>();
            
            if(noteController.note == "F")
            {
                int notePositionX = (int)notes[i].transform.position.x;

                if(notePositionX > 1750 && notePositionX < 1800)
                {
                    Debug.Log("Note Pressed Successfully");
                    score++;
                    Destroy(notes[i]);
                }
            }
        }
    }
    public void OnJ()
    {
        StartCoroutine(BlockCoroutine(m_J));

        for(int i = 0; i < notes.Length; i++)
        {
            NoteController noteController = notes[i].GetComponent<NoteController>();
            
            if(noteController.note == "J")
            {
                int notePositionX = (int)notes[i].transform.position.x;

                if(notePositionX > 1750 && notePositionX < 1800)
                {
                    Debug.Log("Note Pressed Successfully");
                    score++;
                    Destroy(notes[i]);
                }
            }
        }
    }
    public void OnK()
    {
        StartCoroutine(BlockCoroutine(m_K));

        for(int i = 0; i < notes.Length; i++)
        {
            NoteController noteController = notes[i].GetComponent<NoteController>();
            
            if(noteController.note == "K")
            {
                int notePositionX = (int)notes[i].transform.position.x;

                if(notePositionX > 1750 && notePositionX < 1800)
                {
                    Debug.Log("Note Pressed Successfully");
                    score++;
                    Destroy(notes[i]);
                }
            }
        }
    }
    public void OnL()
    {
        StartCoroutine(BlockCoroutine(m_L));

        for(int i = 0; i < notes.Length; i++)
        {
            NoteController noteController = notes[i].GetComponent<NoteController>();
            
            if(noteController.note == "L")
            {
                int notePositionX = (int)notes[i].transform.position.x;

                if(notePositionX > 1750 && notePositionX < 1800)
                {
                    Debug.Log("Note Pressed Successfully");
                    score++;
                    Destroy(notes[i]);
                }
            }
        }
    }
    IEnumerator BlockCoroutine(GameObject m_Something)
    {
        //Print the time of when the function is first called.
        m_Something.transform.localScale += scaleChange;
        m_Something.transform.position += new Vector3(0f, scaleChange.y * 0.5f, 0f);

        yield return new WaitForSeconds(0.2f); // hardcoded, needs to change according to song

        //After we have waited 5 seconds print the time again.
        m_Something.transform.localScale -= scaleChange;
        m_Something.transform.position -= new Vector3(0f, scaleChange.y * 0.5f, 0f);
    }
}
