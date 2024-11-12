using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Note : MonoBehaviour
{
    double timeInstantiated;
    public float assignedTime;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Image>().enabled = false;
        gameObject.transform.GetChild(0).gameObject.SetActive(false);
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
            transform.localPosition = Vector3.Lerp(Vector3.right * songManager.Instance.noteSpawnX, Vector3.right * songManager.Instance.noteDespawnX, t);
            GetComponent<Image>().enabled = true;
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }

    }
}
