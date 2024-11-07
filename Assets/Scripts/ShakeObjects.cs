using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeObjects : MonoBehaviour
{
    public List<Transform> objectsReactingToBasses, objectsReactingToNB, objectsReactingToMiddles, objectsReactingToHighs;
    // Start is called before the first frame update

    [SerializeField] float t = 0.1f;
    [SerializeField] float timer = 10f;
    [SerializeField] Shoot[] shooters;
    bool ifone = true;
    //Type of sound
    private int type = -1;
    float[] music_values;


    void Start()
    {
        music_values = new float[4] {0.0f,0.0f,0.0f,0.0f};
        StartCoroutine(ResetIfOne()); // Iniciar la corrutina en el método Start
    }
    void FixedUpdate()
    {
        makeObjectsShakeScale();
    }

    // Update is called once per frame
    void makeObjectsShakeScale()
    {
        foreach (Transform obj in objectsReactingToBasses)
        {
            obj.localScale = Vector3.Lerp(obj.localScale, new Vector3(MusicManager.instance.getFrequenciesDiapason(0, 7, 10), 1.00f, 1.00f), t);//0.16f, 0.15f), t);
            if (ifone)
            {
                //Dado un lapso de tiempo tomar los valores de estos comparar que tienen mas valores
                Debug.Log(MusicManager.instance.getFrequenciesDiapason(0, 7, 10));
                music_values[0] = MusicManager.instance.getFrequenciesDiapason(0, 7, 10);
            }
                

        }
            


        foreach (Transform obj in objectsReactingToNB)
        {
            obj.localScale = Vector3.Lerp(obj.localScale, new Vector3(MusicManager.instance.getFrequenciesDiapason(7, 15, 100), 1.00f, 1.00f), t);

            if(ifone)
            {
                music_values[1] = MusicManager.instance.getFrequenciesDiapason(7, 15, 100);
            }


        }
            

        foreach (Transform obj in objectsReactingToMiddles)
        {
            obj.localScale = Vector3.Lerp(obj.localScale, new Vector3(MusicManager.instance.getFrequenciesDiapason(15, 30, 200), 1.00f, 1.00f), t);
            if (ifone)
            {
                music_values[2] = MusicManager.instance.getFrequenciesDiapason(15, 30, 200);
            }
        }
            

        foreach (Transform obj in objectsReactingToHighs)
        {
            obj.localScale = Vector3.Lerp(obj.localScale, new Vector3(MusicManager.instance.getFrequenciesDiapason(30, 32, 1000), 1.00f, 1.00f), t);

            if (ifone)
            {
                music_values[3] = MusicManager.instance.getFrequenciesDiapason(30, 32, 1000);
            }
        }

        if (ifone)
        {
            //Which note has the higher value

            ifone = false;

            float max = -0.0000000000000000000000000000000000000000000000000000000000001f;
            int higher = 0;

            for(int i = 0; i < 4; i++)
            {
                if(max < music_values[i])
                {
                    max = music_values[i];
                    higher = i;
                }
            }

            shooters[higher].ActiveBullets();


            Debug.Log(higher);



        }


    }

    IEnumerator ResetIfOne()
    {
        while (true)
        {
            yield return new WaitForSeconds(timer); // Espera 10 segundos
            ifone = true; // Reinicia ifone a verdadero
        }
    }


}
