using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class CarMovement : MonoBehaviour
{
    public float Carspeed = -350f;
    private Vector3 Carmovement;

    public Rigidbody2D CarBody;

    public GameObject CarObject;

    private void FixedUpdate()
    {

        Carmovement = new Vector3(0, 2, 0).normalized;
        CarBody.linearVelocity = new Vector3(0, Carmovement.y * Carspeed, 0) * Time.fixedDeltaTime;

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("CarStop"))
        {

            Destroy(CarObject);
        }
    }
}
