using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour {

    public Door door;
    public Key key;
    public AudioSource audioSource;
    public AudioClip keyAudioClip;
    public AudioClip doorAudioClip;
    private AudioClip previousClip;

    private void Update()
    {
        if (!key.hasKey)
        {
            return;
        }

        previousClip = audioSource.clip;

        if (door.locked)
        {
            audioSource.clip = keyAudioClip;
        }
        else if (!door.locked)
        {
            audioSource.clip = doorAudioClip;
        }

        if (previousClip != audioSource.clip)
        {
            audioSource.Stop();
            audioSource.Play();
        }
    }
}
