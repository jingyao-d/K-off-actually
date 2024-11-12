using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputDetection : MonoBehaviour
{
    [SerializeField] GameObject m_S;
    [SerializeField] GameObject m_D;
    [SerializeField] GameObject m_F;
    [SerializeField] GameObject m_J;
    [SerializeField] GameObject m_K;
    [SerializeField] GameObject m_L;
    private Vector3 scaleChange = new Vector3(0.0f, 1.0f, 0.0f);
    public void OnS()
    {
        StartCoroutine(BlockCoroutine(m_S));
    }
    public void OnD()
    {
        StartCoroutine(BlockCoroutine(m_D));
    }
    public void OnF()
    {
        StartCoroutine(BlockCoroutine(m_F));
    }
    public void OnJ()
    {
        StartCoroutine(BlockCoroutine(m_J));
    }
    public void OnK()
    {
        StartCoroutine(BlockCoroutine(m_K));
    }
    public void OnL()
    {
        StartCoroutine(BlockCoroutine(m_L));
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
