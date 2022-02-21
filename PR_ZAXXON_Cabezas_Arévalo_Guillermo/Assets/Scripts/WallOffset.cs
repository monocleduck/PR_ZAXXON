using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallOffset : MonoBehaviour
{
    public float ScrollY = -0.25f;

    // Update is called once per frame
    void Update()
    {
        float OffsetY = Time.time * ScrollY;

        if (LIVES.vidas > 0)
        {
          this.GetComponent<Renderer>().material.mainTextureOffset = new Vector2(0, OffsetY);
        }
       
    }
}
