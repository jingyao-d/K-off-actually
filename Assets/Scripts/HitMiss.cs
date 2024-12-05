using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitMiss : MonoBehaviour
{
    // Start is called before the first frame update
    public static HitMiss Instance;
    public GameObject hitText;
    public GameObject missText;

    void Start()
    {
        Instance = this;
        hitText.SetActive(false);
        missText.SetActive(false);
    }

    public static void Hit()
    {
        Instance.hitText.SetActive(true);
        Instance.StartCoroutine(HitHide());
    }

    public static void Miss()
    {
        Instance.missText.SetActive(true);
        Instance.StartCoroutine(MissHide());
    }

    
    public static IEnumerator HitHide() {
        yield return new WaitForSeconds(0.1f);
        Instance.hitText.SetActive(false);
    }

    public static IEnumerator MissHide() {
        yield return new WaitForSeconds(0.1f);
        Instance.missText.SetActive(false);
    }
    
}
