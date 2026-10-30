using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Vector3 movement;
    public float speed;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            transform.position += Vector3.left * Time.deltaTime * speed;
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            transform.position += Vector3.right * Time.deltaTime * speed;
        }
        if (Input.GetAxis("Vertical") > 0)
        {
            transform.position += Vector3.back * Time.deltaTime * speed;
        }
        if (Input.GetAxis("Vertical") < 0)
        {
            transform.position += Vector3.forward * Time.deltaTime * speed;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * 5);
        }
    }
}
