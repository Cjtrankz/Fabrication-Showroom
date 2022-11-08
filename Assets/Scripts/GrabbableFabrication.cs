using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabbableFabrication : MonoBehaviour
{
    public MeshRenderer primaryRenderer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void WasGrabbed()
    {
        Fabricator.Instance.StopReferencingObject(gameObject);
    }
}
