using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerControll : MonoBehaviour
{
    private Rigidbody2D rb;
    private float dirX;
    public float speedCurva;
    public static float speed;
    public static bool morreu;

    public GameObject GameOver;
    public GameObject botao, pontos;
    public AudioSource iiihh;

   
    

    private float x;

    
    void Start()
    {
        morreu = false;
        speed = 230f;
        rb = GetComponent<Rigidbody2D>();
        
    }
    

    private void FixedUpdate()
    {
        if (!morreu)
        {
            dirX = (Input.acceleration.x * speedCurva * 100 * Time.deltaTime);
            rb.velocity = new Vector2(dirX, speed * Time.deltaTime);

            //IMPEDIR DE BATER TESTE VERIFICAR FUNCIONALIDADE---- nao funfou

            if (gameObject.transform.position.x > 1.63f) gameObject.transform.Translate(-0.01f, 0, 0);
            if (gameObject.transform.position.x < 1.5f) gameObject.transform.Translate(0.01f, 0, 0);
        }
        else { dirX = 0;
            rb.velocity = new Vector2(dirX, speed * Time.deltaTime);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Inimigo")
        {
            if (!morreu)
            {
                iiihh.Play();
                gameObject.GetComponent<AudioSource>().Pause();
                Destroy(collision.gameObject);
                botao.SetActive(false);
                pontos.SetActive(false);
                StartCoroutine("Rodar");
                StartCoroutine("Parar");
                x = speed / 90;
                morreu = true;
            }
        }
    }

    IEnumerator Rodar()
    {
        for (int i = 0; i < 45; i++)
        {
            gameObject.transform.Rotate(0f, 0f, gameObject.transform.rotation.z + 5f, Space.Self);
            yield return null;

        }
    }

    IEnumerator Parar()
    {
        yield return new WaitForSeconds(0.8f);
        for (int i = 0; i < 91; i++)
        {
            speed -= x;
        }
        speed = 0;
        GameOver.SetActive(true);

    }

  
}
