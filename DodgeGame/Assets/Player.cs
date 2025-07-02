using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    private Rigidbody playerRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        /*transform
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0f, 0f, speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0f, 0f, -speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-speed * Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(speed * Time.deltaTime, 0f, 0f);
        }
        */
        /*addforce
        if (Input.GetKey(KeyCode.UpArrow))
        {
            playerRigidbody.AddForce(0f, 0f, speed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            playerRigidbody.AddForce(0f, 0f, -speed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerRigidbody.AddForce(-speed, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            playerRigidbody.AddForce(speed, 0f, 0f);
        }
        */

        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        Vector3 newVelocity = new Vector3(xSpeed, 0, zSpeed);
        playerRigidbody.velocity = newVelocity;

        if(Input.GetKey(KeyCode.Space))
        {
            Die();
        }
    }

    public void Die()
    {
        gameObject.SetActive(false);

        GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.EndGame();
    }
}
