using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class NoteSpawner : MonoBehaviour
{
    [SerializeField] GameObject noteS;
    [SerializeField] GameObject noteD;
    [SerializeField] GameObject noteF;
    [SerializeField] GameObject noteJ;
    [SerializeField] GameObject noteK;
    [SerializeField] GameObject noteL;
    [SerializeField] GameObject noteSpawnPosition;

    void SpawnNote(GameObject noteToSpawn)
    {
        Instantiate(noteToSpawn,noteSpawnPosition.transform);
    }
}
