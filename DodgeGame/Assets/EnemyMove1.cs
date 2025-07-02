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
        enemyRigidbody.velocity = new Vector3(speed * Time.deltaTime, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
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
