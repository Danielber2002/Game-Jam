using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBackgrounds : MonoBehaviour
{
    public GameObject objeto1;
    public GameObject objeto2;

    void Start()
    {
        StartCoroutine(RutinaCambio());
    }

    IEnumerator RutinaCambio()
    {
        while (true)
        {
            objeto1.SetActive(true);
            objeto2.SetActive(false);

            yield return new WaitForSeconds(2.5f);

            objeto1.SetActive(false);
            objeto2.SetActive(true);

            yield return new WaitForSeconds(2.5f);
        }
    }
}