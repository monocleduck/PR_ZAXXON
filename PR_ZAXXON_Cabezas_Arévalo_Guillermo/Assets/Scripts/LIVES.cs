using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LIVES : MonoBehaviour
{

    public static int vidas;
    [SerializeField] Image LivesImage;
    [SerializeField] Sprite[] spriteVidas;

    public GameObject DeathScreen, VidasUI;

    public Text ScoreTxt;
    public static float Score;

    float HScore;

    GameObject HScoreMenu;

    [SerializeField] AudioClip Explosion;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {

        audioSource = GetComponent<AudioSource>();

        vidas = 3;
        gameObject.SetActive(true);

        DeathScreen = GameObject.Find("MenuDeath");
        VidasUI = GameObject.Find("Vidas");


        VidasUI.GetComponent<AudioSource>().gameObject.SetActive(false);
         


        LivesImage.sprite = spriteVidas[vidas];




        StartCoroutine("ScoreManager");




    }

    // Update is called once per frame
    void Update()
    {
        ScoreTxt.text = "" + Score;
        Chocar();
        VidaMuerte();

       
    }

    void Chocar()
    {


        LivesImage.sprite = spriteVidas[vidas];

    }

    
    void VidaMuerte()
    {
        if (vidas > 0)
        {
            

            VidasUI.SetActive(true);
            DeathScreen.SetActive(false);
        }
        
        
        
        if( vidas <= 0)
        {
            //StartCoroutine("Esperar");



            //audioSource.Play();

            VidasUI.GetComponent<AudioSource>().gameObject.SetActive(true);

            VidasUI.SetActive(false);
            DeathScreen.SetActive(true);
        }
    }
    

    IEnumerator Esperar()
    {
        while (true)
        {
            yield return  new WaitForSeconds(4f);
        }
    }
    
    IEnumerator ScoreManager()
    {
        while (vidas>0)
        {
            Score += 1;

            yield return new WaitForSeconds(0.1f);

                 
        }
    }

   
}
