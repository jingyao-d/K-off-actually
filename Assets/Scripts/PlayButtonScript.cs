using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    [SerializeField] AudioSource SFXSource;
    [SerializeField] AudioClip buttonClip;

    // Start is called before the first frame update
    public void ChangeScene() {
        SFXSource.PlayOneShot(buttonClip);
        DontDestroyOnLoad(SFXSource);
        SceneManager.LoadScene("GameScene2");
    }
}
