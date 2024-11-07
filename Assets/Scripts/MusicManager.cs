using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public static MusicManager instance;
    public float[] spectrumWidth;
    AudioSource audioSource;


    void Awake()
    {
        spectrumWidth = new float[64];
        audioSource = GetComponent<AudioSource>();
        instance = this;
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        audioSource.GetSpectrumData(spectrumWidth, 0, FFTWindow.Blackman);
    }

    public float getFrequenciesDiapason(int start, int end, int mult)
    {
        
        return spectrumWidth.ToList().GetRange(start, end).Average() * mult * 3;
    }
}
