using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAudioVoices : MonoBehaviour
{
    public AudioSource dogAudio;
    public AudioSource catAudio;

    // Start is called before the first frame update
    public void playCreditsButton()
    {
        dogAudio.Play();
    }

    public void playSettingsButton()
    {
        catAudio.Play();
    }
}
