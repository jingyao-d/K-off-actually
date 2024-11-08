using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputDetection : MonoBehaviour
{
    GameObject[] notes;
    private int score;

    void Update()
    {
        notes = GameObject.FindGameObjectsWithTag("Note");
    }
    public void OnS()
    {

        for(int i = 0; i < notes.Length; i++)
        {
            NoteController noteController = notes[i].GetComponent<NoteController>();
            
            if(noteController.note == "S")
            {
                int notePositionX = (int)notes[i].transform.position.x;

                if(notePositionX > 1600 && notePositionX < 1700)
                {
                    Debug.Log("Note Pressed Successfully");
                    score = score + 100;
                    Destroy(notes[i]);
                }
            }
        }
    }
    public void OnD()
    {

        for(int i = 0; i < notes.Length; i++)
        {
            NoteController noteController = notes[i].GetComponent<NoteController>();
            
            if(noteController.note == "D")
            {
                int notePositionX = (int)notes[i].transform.position.x;

                if(notePositionX > 1600 && notePositionX < 1700)
                {
                    Debug.Log("Note Pressed Successfully");
                    score = score + 100;
                    Destroy(notes[i]);
                }
            }
        }
    }
    public void OnF()
    {

        for(int i = 0; i < notes.Length; i++)
        {
            NoteController noteController = notes[i].GetComponent<NoteController>();
            
            if(noteController.note == "F")
            {
                int notePositionX = (int)notes[i].transform.position.x;

                if(notePositionX > 1600 && notePositionX < 1700)
                {
                    Debug.Log("Note Pressed Successfully");
                    score = score + 100;
                    Destroy(notes[i]);
                }
            }
        }
    }
    public void OnJ()
    {

        for(int i = 0; i < notes.Length; i++)
        {
            NoteController noteController = notes[i].GetComponent<NoteController>();
            
            if(noteController.note == "J")
            {
                int notePositionX = (int)notes[i].transform.position.x;

                if(notePositionX > 1600 && notePositionX < 1700)
                {
                    Debug.Log("Note Pressed Successfully");
                    score = score + 100;
                    Destroy(notes[i]);
                }
            }
        }
    }
    public void OnK()
    {

        for(int i = 0; i < notes.Length; i++)
        {
            NoteController noteController = notes[i].GetComponent<NoteController>();
            
            if(noteController.note == "K")
            {
                int notePositionX = (int)notes[i].transform.position.x;

                if(notePositionX > 1600 && notePositionX < 1700)
                {
                    Debug.Log("Note Pressed Successfully");
                    score = score + 100;
                    Destroy(notes[i]);
                }
            }
        }
    }
    public void OnL()
    {

        for(int i = 0; i < notes.Length; i++)
        {
            NoteController noteController = notes[i].GetComponent<NoteController>();
            
            if(noteController.note == "L")
            {
                int notePositionX = (int)notes[i].transform.position.x;

                if(notePositionX > 1600 && notePositionX < 1700)
                {
                    Debug.Log("Note Pressed Successfully");
                    score = score + 100;
                    Destroy(notes[i]);
                }
            }
        }
    }
}
