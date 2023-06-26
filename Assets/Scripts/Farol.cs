using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Farol : MonoBehaviour
{
    public TextMeshProUGUI number;
    private int numero;
    public GameObject farol;

    private void Start()
    {
        numero = 3;
        number.text = numero.ToString();
    }
    private void Update()
    {
        number.text = numero.ToString();
    }

    public void Lansa()
    {
        if (!PlayerControll.morreu)
        {
            StartCoroutine("AtivaFarol");
        }
    }
    public IEnumerator AtivaFarol()
    {
        if (numero > 0)
        {
            numero--;
            farol.SetActive(true);
            yield return new WaitForSeconds(2);
            farol.SetActive(false);
        }
    }
}
