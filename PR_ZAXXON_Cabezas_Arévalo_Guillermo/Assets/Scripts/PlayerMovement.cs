using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    private Vector3 Movement = new Vector3(0f, 0f, 0f);

    public static float speed =  20f;

    public int Vuln = 3;


    


    // Start is called before the first frame update
    void Start()
    {

        

    }

    // Update is called once per frame
    void Update()
    {
        

        Desplazarse();
        Velocidad();

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



        if ((playY < 7.5 || DesplV < 0) && (playY > -3 || DesplV > 0))
        {


            transform.Translate(Vector3.up * Time.deltaTime * speed * DesplV);
        }



    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {

            if (Vuln == 3)
            {
                Vuln = 0;

                StartCoroutine("Invuln");

                int lives = LIVES.vidas;

                if (lives > 0)
                {
                    LIVES.vidas--;
                    
                }


            }


        }



    }



    public void Velocidad()
    {
        if(LIVES.vidas <= 0)
        {
            speed = 0;

            ParticleSystem Explosion = GetComponent<ParticleSystem>();
            Explosion.Play();
            
        }
        else
        {
            speed = 20f;
        }
    }

    /*IEnumerator Respawn()
    {
        while (true)
        {
            SceneManager.LoadScene("Juego");

            LIVES.vidas = 2;

            yield return new WaitForSeconds(5f);
        }
    }
    */

    IEnumerator Invuln()
    {
        while (true)
        {

            if (Vuln < 3)
            {

                Vuln++;

                
            }
       
            yield return new WaitForSeconds(0.5f);
    
        }
    }
    
    


}
