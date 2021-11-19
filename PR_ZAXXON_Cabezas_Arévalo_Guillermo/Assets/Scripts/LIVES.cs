using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LIVES : MonoBehaviour
{

    public static int vidas = 3;
    [SerializeField] Image LivesImage;
    [SerializeField] Sprite[] spriteVidas;


    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);


        LivesImage.sprite = spriteVidas[vidas];

    }

    // Update is called once per frame
    void Update()
    {

        Chocar();
    }

    void Chocar()
    {


        LivesImage.sprite = spriteVidas[vidas];

    }

    
    void VidaMuerte()
    {
        if (vidas > 0)
        {
            gameObject.SetActive(true);
        }
        
        
        
        if( vidas == 0)
        {
            //StartCoroutine("Esperar");

            gameObject.SetActive(false);
        }
    }


    IEnumerator Esperar()
    {
        while (true)
        {
            yield return  new WaitForSeconds(4f);
        }
    }

}
