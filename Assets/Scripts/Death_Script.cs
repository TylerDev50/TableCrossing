using UnityEngine;

public class Death_Script : MonoBehaviour
{

    public GameObject player;
    public Transform respawnPoint;

    AudioManager AudioManager;

    private void Awake()
    {
        AudioManager = GameObject.FindGameObjectsWithTag("AudioManager")[0].GetComponent<AudioManager>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            player.transform.position = respawnPoint.position;
            player.transform.rotation = respawnPoint.rotation;
            AudioManager.PlaySFX(AudioManager.DeathSound);
            Debug.Log("Player Respawned");
        }
    }
}
