using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour
{
    [SerializeField] Transform PlayerMovement;
    [SerializeField] float smoothVelocity = 0.3f;
    [SerializeField] Vector3 cameraVelocity = Vector3.zero;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = new Vector3(PlayerMovement.transform.position.x, PlayerMovement.position.y + 2, transform.position.z);
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref cameraVelocity, smoothVelocity);
    }
}
