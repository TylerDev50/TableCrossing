using UnityEngine;
using System.Collections;

public class CarSpawner : MonoBehaviour
{
    public GameObject Pfab_Car;
    public float TimeBetweenSpawnds;
    public Transform CarSpawnPoint;


    private void Start()
    {
        StartCoroutine(SpawnCarTime());
    }

    IEnumerator SpawnCarTime()
    {
        SpawnCar();
        yield return new WaitForSeconds(TimeBetweenSpawnds);
        StartCoroutine(SpawnCarTime());
    }

    private void SpawnCar()
    {
        TimeBetweenSpawnds = Random.Range(4f, 6f);
        Instantiate(Pfab_Car, CarSpawnPoint.transform.position, CarSpawnPoint.transform.rotation);
    }
}
