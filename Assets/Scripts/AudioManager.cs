using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("AudioSource")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource sfxSource;


    [Header("AudioClip")]
    public AudioClip backgroundMusic;
    public AudioClip DeathSound;
    public AudioClip NextLevelSound;

    private void Start()
    {
        musicSource.clip = backgroundMusic;
        musicSource.Play(); 
    }

    public void PlaySFX(AudioClip clip)
    {
        sfxSource.PlayOneShot(clip);
    }
}
