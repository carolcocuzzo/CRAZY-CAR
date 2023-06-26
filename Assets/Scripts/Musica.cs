using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musica : MonoBehaviour
{
    private void Awake()
    {
        GameObject[] objetos = GameObject.FindGameObjectsWithTag("music");
        if (objetos.Length > 1)
            Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
    }
    
    
}
