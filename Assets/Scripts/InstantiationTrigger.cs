using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiationTrigger : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public Transform spawnLocation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("spawning prefab");
            Instantiate(prefabToSpawn, spawnLocation.position, spawnLocation.rotation);
        }
    }
}
