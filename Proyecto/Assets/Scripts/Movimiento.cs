using UnityEngine;

public class Movimiento : MonoBehaviour{

    public Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello, World!");
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("w")) {
            rb.AddForce(0, 0, 400 * Time.deltaTime);   
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -400 * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(400 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-400 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("space"))
        {
            rb.AddForce(0, 1, 0, ForceMode.Impulse);
        }
        if (rb.position.y > 1)
        {
            rb.AddForce(0, -2, 0, ForceMode.Impulse);
        }
        /*
        if (rb.rotation.x > 45 || rb.rotation.x < -45)
        {
            rb.AddForce(0, 7, 0, ForceMode.Impulse);
        }
        if (rb.rotation.z > 45 || rb.rotation.z < -45)
        {
            rb.AddForce(0, 7, 0, ForceMode.Impulse);
        }
        */

        if (rb.position.y < -1)
        {
            FindObjectOfType<GameManager>().EndGame();
        }






    }
}
