using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    
    void Start()
    {
        StartCoroutine("Reinicia");
    }

   IEnumerator Reinicia()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("Jogo");

    }
}
