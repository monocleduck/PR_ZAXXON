using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    private Vector3 Movement = new Vector3(0f, 0f, 0f);

    public float speed;

    public int Vuln = 3;




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
                //Vuln = 0;

               // StartCoroutine("Invuln");

                int lives = LIVES.vidas;

                if (lives > 0)
                {
                    LIVES.vidas--;

                    speed = 1f;

                    while (speed > 0 && speed < 20)
                    {
                        speed = speed * 1.1f;


                    }
                }

                else
                {
                    StartCoroutine("Respawn");

                }


            }


        }



    }



    IEnumerator Respawn()
    {
        while (true)
        {
            SceneManager.LoadScene("Juego");

            LIVES.vidas = 2;

            yield return new WaitForSeconds(5f);
        }
    }

    /*IEnumerator Invuln()
    {
        while (true)
        {

            if (Vuln < 3)
            {

                Vuln++;

                print(Vuln);

                yield return new WaitForSeconds(0.5f);

            }
        }
    }
    */



}
