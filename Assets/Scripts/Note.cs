using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    double timeInstantiated;
    public float assignedTime;
    // Start is called before the first frame update
    void Start()
    {
        timeInstantiated = songManager.GetAudioSourceTime();
    }

    // Update is called once per frame
    void Update()
    {
        double timeSinceInstantiated = songManager.GetAudioSourceTime() - timeInstantiated;
        float t = (float)(timeSinceInstantiated / (songManager.Instance.noteTime * 2));
        if (t > 1)
            Destroy(gameObject);
        else
        {
            transform.localPosition = Vector3.Lerp(Vector3.up * songManager.Instance.noteSpawnY, Vector3.up * songManager.Instance.noteDespawnY, t);
        }

    }
}
