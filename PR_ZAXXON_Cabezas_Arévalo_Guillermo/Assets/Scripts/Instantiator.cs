using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{

    float intervaloCol;
    
    //PlayerMovement playerMovement;
    
    [SerializeField] GameObject ColumnaPrefab;
    [SerializeField] Transform instantiatePos;
    [SerializeField] Transform PlayerMovement;



    // Start is called before the first frame update
    void Start()
    {
        //playerMovement = GameObject.Find("Cube").GetComponent<PlayerMovement>();

        intervaloCol = 0.25f;

        StartCoroutine("CrearColumna");

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    


    IEnumerator CrearColumna()
    {
        while (true)
        {
            float RandomInclin = Random.Range(0, 360);

            float randomY = Random.Range(-3f, 15f);

            float randomX = Random.Range(-5f, 5f);

            Vector3 newPos = new Vector3(randomX, randomY, instantiatePos.position.z);
            Instantiate(ColumnaPrefab, newPos, Quaternion.Euler(0f, 0f, RandomInclin));

            yield return new WaitForSeconds(intervaloCol);
        }
    }

    




 }

