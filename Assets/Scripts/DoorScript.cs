using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1Door : MonoBehaviour
{
    AudioManager AudioManager;


    private void Awake()
    {
        AudioManager = GameObject.FindGameObjectsWithTag("AudioManager")[0].GetComponent<AudioManager>();
    }
    

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            AudioManager.PlaySFX(AudioManager.NextLevelSound);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
