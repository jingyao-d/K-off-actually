using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.InputSystem;

public class NoteSpawner : MonoBehaviour
{
    [SerializeField] GameObject noteS;
    [SerializeField] GameObject noteD;
    [SerializeField] GameObject noteF;
    [SerializeField] GameObject noteJ;
    [SerializeField] GameObject noteK;
    [SerializeField] GameObject noteL;
    [SerializeField] GameObject noteSSpawnPostiion;
    [SerializeField] GameObject noteDSpawnPostiion;
    [SerializeField] GameObject noteFSpawnPostiion;
    [SerializeField] GameObject noteJSpawnPostiion;
    [SerializeField] GameObject noteKSpawnPostiion;
    [SerializeField] GameObject noteLSpawnPostiion;
    Transform noteSpawnPosition;

    void Start()
    {
        SpawnNote(noteS);
        SpawnNote(noteD);
        SpawnNote(noteF);
        SpawnNote(noteJ);
        SpawnNote(noteK);
        SpawnNote(noteL);
    }

    public void SpawnNote(GameObject noteToSpawn)
    {
        NoteController noteController = noteToSpawn.GetComponent<NoteController>();

        if(noteController.note == "S")
        {
            noteSpawnPosition = noteSSpawnPostiion.transform;
            Instantiate(noteToSpawn,noteSpawnPosition);
        }
        else if(noteController.note == "D")
        {
            noteSpawnPosition = noteDSpawnPostiion.transform;
            Instantiate(noteToSpawn,noteSpawnPosition);
        }
        else if(noteController.note == "F")
        {
            noteSpawnPosition = noteFSpawnPostiion.transform;
            Instantiate(noteToSpawn,noteSpawnPosition);
        }
        else if(noteController.note == "J")
        {
            noteSpawnPosition = noteJSpawnPostiion.transform;
            Instantiate(noteToSpawn,noteSpawnPosition);
        }
        else if(noteController.note == "K")
        {
            noteSpawnPosition = noteKSpawnPostiion.transform;
            Instantiate(noteToSpawn,noteSpawnPosition);
        }
        else if(noteController.note == "L")
        {
            noteSpawnPosition = noteLSpawnPostiion.transform;
            Instantiate(noteToSpawn,noteSpawnPosition);
        }

    }
}
