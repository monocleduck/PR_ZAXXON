using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LIVES : MonoBehaviour
{

    public static int vidas = 2;
    [SerializeField] Image LivesImage;
    [SerializeField] Sprite[] spriteVidas;

    // Start is called before the first frame update
    void Start()
    {


        
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

    


}
