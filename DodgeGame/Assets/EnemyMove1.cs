using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove1 : MonoBehaviour
{
    public float speed = 7f;
    private Rigidbody enemyRigidbody;
    

    // Start is called before the first frame update
    void Start()
    {
        enemyRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.tag == "ENEMY1")
        {
            transform.Translate(0f, 0f, speed * Time.deltaTime);
        }
        else if(gameObject.tag == "ENEMY2")
        {
            transform.Translate(speed * Time.deltaTime, 0f, 0f);
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ANCHOR")
        {
            if(speed > 0)
            {
                speed -= speed * 2;
            }
            else if(speed < 0)
            {
                speed -= speed * 2;
            }
        }
    }
}
