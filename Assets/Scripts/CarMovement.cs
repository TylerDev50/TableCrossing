using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class CarMovement : MonoBehaviour
{
    public float Carspeed;
    private Vector3 Carmovement;

    public Rigidbody2D CarBody;

    public GameObject CarObject;

    private void FixedUpdate()
    {

        Debug.Log(CarBody.transform.rotation.eulerAngles.z);
        Carmovement = new Vector3(2, 2, 0).normalized;

        if (CarBody.transform.rotation.eulerAngles.z == 180)
        {
            CarBody.linearVelocity = new Vector3(0, -Carmovement.y * Carspeed, 0) * Time.fixedDeltaTime;
            Debug.Log("Down");
        }
        else if (CarBody.transform.rotation.eulerAngles.z == 0)
        {
            CarBody.linearVelocity = new Vector3(0, Carmovement.y * Carspeed, 0) * Time.fixedDeltaTime;
            Debug.Log("Up");
        }
        else if (CarBody.transform.rotation.eulerAngles.z == 90)
        {
            CarBody.linearVelocity = new Vector3(-Carmovement.x * Carspeed, 0, 0) * Time.fixedDeltaTime;
            Debug.Log("Right");
        }
        else if (CarBody.transform.rotation.eulerAngles.z == 270)
        {
            CarBody.linearVelocity = new Vector3(Carmovement.x * Carspeed, 0, 0) * Time.fixedDeltaTime;
            Debug.Log("Left");
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("CarStop"))
        {

            Destroy(CarObject);
        }
    }
}
