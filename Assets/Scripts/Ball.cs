using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
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
            GetComponent<Image>().enabled = true;
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }

    }
}
