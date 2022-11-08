using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInteraction : MonoBehaviour
{
    Vector3 startingSize;
    public float sizeMultiplier;
    // Start is called before the first frame update
    void Start()
    {
        startingSize = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Grow()
    {
        transform.localScale = startingSize * sizeMultiplier;
    }

    public void Shrink()
    {
        transform.localScale = startingSize;
    }
}
