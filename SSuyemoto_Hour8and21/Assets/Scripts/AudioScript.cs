using UnityEngine;

public class AudioScript : MonoBehaviour
{
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        /*
        bool ToggleAudio(Input.GetKeyDown(KeyCode.K))
        {
            if (audioSource.isPlaying != true)
                audioSource.Stop();
            else
                audioSource.Play();
        }
        */ 
        //Couldn't quite figure out the extra credit in time, but I am curious to know what the answer is
 
        
        if (Input.GetKeyDown(KeyCode.K))
        {
            if (audioSource.isPlaying == true)
                audioSource.Stop();
            else
                audioSource.Play();
        }
        
    }
}