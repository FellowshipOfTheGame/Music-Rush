using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class Points : MonoBehaviour
{
    public KeyCode tecla;
    //public TMP_Text scoreText;
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        //UpdateScoreText();
    }

    // Update is called once per frame
    void Update()
    {

        // Detecta si la tecla "W" es mantenida presionada
        /*if ()
        {
            Debug.Log("Tecla H mantenida presionada!");
            pressed = true;
        }*/


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("On trigger");
        // Check if the object collided with a "DeathZone" tagged object
        if (collision.CompareTag("Metorite1") && Input.GetKey(tecla))
        {
            //Debug.Log("3 stars");
            Destroy(collision.gameObject);
            IncrementScore();
        }
        /*if (collision.CompareTag("2-stars") && pressed)
        {
            Debug.Log("2 stars");
            pressed = false;
            Destroy(gameObject);

        }
        if (collision.CompareTag("1-stars")&& pressed)
        {
            Debug.Log("1 stars");
            pressed = false;
            Destroy(gameObject);
        }*/

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        // Este método se llama cada cuadro mientras un objeto permanece dentro del trigger

        // Verifica si el objeto que colisiona tiene la etiqueta "Metorite1" y si se está presionando la tecla especificada
        if (collision.CompareTag("Metorite1") && Input.GetKey(tecla))
        {
            //
            //Debug.Log("Dentro del Trigger con Metorite1 y tecla presionada");
            Destroy(collision.gameObject);
            IncrementScore();
            // Aquí puedes agregar las acciones que quieres que se ejecuten mientras el objeto está dentro del trigger
        }
    }

    public void IncrementScore()
    {
        //Debug.Log("Incrementar01:");
        score += 1;
        //Debug.Log(score);
        //UpdateScoreText(); // Actualiza el texto en pantalla
    }
    //private void UpdateScoreText()
    //{
    //    scoreText.text = score.ToString("D2"); // Actualiza el texto con el puntaje, formato de dos dígitos
    //}


}
