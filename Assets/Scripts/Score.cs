using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class Score : MonoBehaviour
{
    public TextMeshProUGUI score;
    
    private float pontos;

    public TextMeshProUGUI highScore;

    public TextMeshProUGUI score2;
    
    void Start()
    {
        score.text = "0";
        pontos = 0;

        highScore.text = PlayerPrefs.GetFloat("highScore", 0).ToString();
      
    }


    void Update()
    {
        if (!PlayerControll.morreu)
        {
            pontos += Time.deltaTime * 100;
        }
        pontos = Mathf.Round(pontos);

        if (pontos > PlayerPrefs.GetFloat("highScore", 0))
        {
            PlayerPrefs.SetFloat("highScore", pontos);
            highScore.text = pontos.ToString();
        }
    }

    private void LateUpdate()
    {
        score.text = pontos.ToString();
        score2.text = pontos.ToString();
    }
}
