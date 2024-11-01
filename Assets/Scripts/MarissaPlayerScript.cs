using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class MarissaPlayerScript : MonoBehaviour
{
    [SerializeField] GameObject m_S;
    [SerializeField] GameObject m_D;
    [SerializeField] GameObject m_F;
    [SerializeField] GameObject m_J;
    [SerializeField] GameObject m_K;
    [SerializeField] GameObject m_L;
    private Vector3 scaleChange = new Vector3(0.0f, 1.0f, 0.0f);
    void OnS()
    {
        Debug.Log("S");
        StartCoroutine(BlockCoroutine(m_S));


    }
    void OnD()
    {
        Debug.Log("D");
        StartCoroutine(BlockCoroutine(m_D));
    }
    void OnF()
    {
        Debug.Log("F");
        StartCoroutine(BlockCoroutine(m_F));
    }
    void OnJ()
    {
        Debug.Log("J");
        StartCoroutine(BlockCoroutine(m_J));
    }
    void OnK()
    {
        Debug.Log("K");
        StartCoroutine(BlockCoroutine(m_K));
    }
    void OnL()
    {
        Debug.Log("L");
        StartCoroutine(BlockCoroutine(m_L));
    }

    IEnumerator BlockCoroutine(GameObject m_Something)
    {
        //Print the time of when the function is first called.
        m_Something.transform.localScale += scaleChange;
        m_Something.transform.position += new Vector3(0f, scaleChange.y * 0.5f, 0f);
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        yield return new WaitForSeconds(0.2f); // hardcoded, needs to change according to song

        //After we have waited 5 seconds print the time again.
        m_Something.transform.localScale -= scaleChange;
        m_Something.transform.position -= new Vector3(0f, scaleChange.y * 0.5f, 0f);
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }
}
