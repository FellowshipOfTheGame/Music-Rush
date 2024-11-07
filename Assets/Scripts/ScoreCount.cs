using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreCount : MonoBehaviour
{
    public TMP_Text scoreText;
    public Points[] points;

    private int scr = 0;
    // Start is called before the first frame update
    void Start()
    {
        UpdateScoreText();
    }

    // Update is called once per frame
    void Update()
    {
        IncrementScore();
    }
    public void IncrementScore()
    {
        for (int i = 0; i < points.Length; i++) 
        {
            scr += points[i].score;
        }

        //for (int i = 0; i < points.Length; i++)
        //{
        //    points[i].score = 0;
        //}


        //Debug.Log("Incrementar01:");
        UpdateScoreText(); // Actualiza el texto en pantalla
    }
    private void UpdateScoreText()
    {
        scoreText.text = scr.ToString("D2"); // Actualiza el texto con el puntaje, formato de dos dígitos
        scr = 0;
    }
}
