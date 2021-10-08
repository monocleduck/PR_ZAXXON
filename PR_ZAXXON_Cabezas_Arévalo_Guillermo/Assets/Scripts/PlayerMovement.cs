using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Vector3 Movement = new Vector3 (0f, 0f, 0f);

    public float speed;

    

    


    // Start is called before the first frame update
    void Start()
    {
        speed = 20f;
            
    }

    // Update is called once per frame
    void Update()
    {
        Desplazarse();

        
    }

    void Desplazarse()
    {
        float playX = transform.position.x;
        float playY = transform.position.y;

        float DesplH = Input.GetAxis("Horizontal");
        float DesplV = Input.GetAxis("Vertical");

        if ((playX < 5 || DesplH < 0) && (playX > -5 || DesplH > 0))
        {
            

            transform.Translate(Vector3.right * Time.deltaTime * speed * DesplH);
        }
        

        
        if((playY < 7.5 || DesplV < 0) && (playY > -3 || DesplV > 0))
        {
            

            transform.Translate(Vector3.up * Time.deltaTime * speed * DesplV);
        }

        

    }









}
