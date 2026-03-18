using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource backgroundSource;
    [SerializeField] AudioSource sfxSource;

    public AudioClip background;
    public AudioClip death;
    public AudioClip jump;
    public AudioClip meow;


    private void Start()
    {
        Debug.Log("Audio started");
        backgroundSource.clip = background;
        backgroundSource.Play();
        DontDestroyOnLoad(gameObject);
    }

    public void PlaySFX(AudioClip clip)
    {
        sfxSource.PlayOneShot(clip);
        DontDestroyOnLoad (gameObject);
    }
}
