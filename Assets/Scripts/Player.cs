 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    private Animation thisAnimation;
    public float jumpForce = 10f;
    private Rigidbody rb;
    void Start()
    {
        thisAnimation = GetComponent<Animation>();
        rb = GetComponent<Rigidbody>();
        thisAnimation["Flap_Legacy"].speed = 3;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            thisAnimation.Play();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }
    void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
 void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            
            Destroy(collision.gameObject);
            SceneManager.LoadScene("GameOver");
        }
        if (collision.gameObject.CompareTag("Cube"))
        {

            Destroy(collision.gameObject);
            SceneManager.LoadScene("GameOver");
        }
        if (collision.gameObject.CompareTag("tOP"))
        {

            this.transform.position = new Vector3(0, 0, 0);
        }
    }
}
