using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pista : MonoBehaviour
{
    public GameObject OtraPista;

    public Transform Carro;

    public Transform Bambi, Pedra, Buraco, Guaxinim;

    
   
    
    void Update()
    {
        if (Carro.position.y > gameObject.transform.position.y && gameObject.transform.position.y > OtraPista.transform.position.y)
        {
            Bambi.gameObject.SetActive(true);
            Pedra.gameObject.SetActive(true);
            Buraco.gameObject.SetActive(true);
            Guaxinim.gameObject.SetActive(true);
            Bambi.position = new Vector2(Random.Range(-1.49f, 1.66f), Bambi.position.y);
            Pedra.position = new Vector2(Random.Range(-1.49f, 1.66f), Pedra.position.y);
            Buraco.position = new Vector2(Random.Range(-1.49f, 1.66f), Buraco.position.y);
            Guaxinim.position = new Vector2(Random.Range(-1.49f, 1.66f), Guaxinim.position.y);

            PlayerControll.speed += 20;
            OtraPista.transform.position = new Vector2(OtraPista.transform.position.x, OtraPista.transform.position.y + 60);
            
        }
    }

    
}
