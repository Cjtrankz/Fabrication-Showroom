using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FirstScript : MonoBehaviour
{
    public int numberOfFrames;
    public TextMeshPro refText;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World!");
        numberOfFrames = 0;
        refText.text = "Hello World!!";
    }

    // Update is called once per frame
    void Update()
    {
        //numberOfFrames = numberOfFrames + 1;
        //Debug.Log("numberOfFrames: " + numberOfFrames.ToString());
    }
}
