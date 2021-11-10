using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerkInstantiator : MonoBehaviour
{
    [SerializeField] Transform instantiatePos;
    float intervaloPer;
    [SerializeField] GameObject PERK;


    // Start is called before the first frame update
    void Start()
    {
        intervaloPer = 0.25f;
        StartCoroutine("PerkSpawn");
    }

    // Update is called once per frame
    void Update()
    {
        

        
    }


    IEnumerator PerkSpawn()
    {
        while (true)
        {
            

            float randomX = Random.Range(-5f, 5f);

            float randomY = Random.Range(-3f, 8f);

            Vector3 newPos = new Vector3(randomX, randomY, instantiatePos.position.z);

            Instantiate(PERK, newPos, Quaternion.identity);

            yield return new WaitForSeconds(intervaloPer);
        }
    }

}
