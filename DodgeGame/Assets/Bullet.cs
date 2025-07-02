using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f;
    private Rigidbody bulletRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody>();
        bulletRigidbody.velocity = speed * transform.forward;

        Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if(other.GetComponent<Player>().shield == true)
            {
                Destroy(gameObject);
                other.GetComponent<Player>().shield = false;
            }
            else
            {
                other.GetComponent<Player>().Die();
                Destroy(gameObject);
            }
                
        }
    }
}
