using UnityEngine;

public class Player_audio : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip coinsSound;
    public AudioClip jumpSound;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlaySFX(AudioClip sfx) 
    { 
        audioSource.PlayOneShot(sfx);
    
    }
}

