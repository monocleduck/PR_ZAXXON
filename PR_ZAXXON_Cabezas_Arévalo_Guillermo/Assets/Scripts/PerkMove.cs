using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerkMove : MonoBehaviour
{

    float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        speed = PlayerMovement.speed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * speed);

        if (transform.position.z < -10)
        {
            Destroy(gameObject);
        }

        speed = PlayerMovement.speed;
    }
}
