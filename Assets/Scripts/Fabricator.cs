using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fabricator : MonoBehaviour
{
    public static Fabricator Instance;

    GameObject heldPrefab;

    public Transform prefabSpawnpoint;
    public Transform FXSpawnPoint;

    Material fabricationMaterial;
    public Material startingMaterial;

    List<GameObject> spawnedFabrications;

    GameObject SnowFX;
    public GameObject destructionPrefabFX;
    public float destructionTime;

    public Animator anim;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("fabricator script running");
        fabricationMaterial = startingMaterial;
        spawnedFabrications = new List<GameObject>();
    }

    public void SpawnPrefab(GameObject prefabToSpawn)
    {
        Debug.Log("spawning prefab now");
        if(heldPrefab != null)
        {
            Destroy(heldPrefab);
        }
        heldPrefab = Instantiate(prefabToSpawn, prefabSpawnpoint.position, prefabSpawnpoint.rotation, prefabSpawnpoint);
        ChangeMaterial(fabricationMaterial);
        anim.SetTrigger("PlayFabrication");
    }

    public void SpawnFX(GameObject FXToSpawn)
    {
        Debug.Log("spawning fx now");
        if(SnowFX == null)
        {
            //Destroy(SnowFX);
            SnowFX = Instantiate(FXToSpawn, FXSpawnPoint.position, FXSpawnPoint.rotation, FXSpawnPoint);
        }
    }

    public void ChangeMaterial(Material recievedMaterial)
    {
        fabricationMaterial = recievedMaterial;
        if(heldPrefab != null)
        {
            heldPrefab.GetComponent<GrabbableFabrication>().primaryRenderer.material = recievedMaterial;
        }
        anim.SetTrigger("ChangeMesh");
    }

    public void StopReferencingObject(GameObject objectToStopReferencing)
    {
        if(heldPrefab = objectToStopReferencing)
        {
            spawnedFabrications.Add(objectToStopReferencing);
            heldPrefab = null;
            Destroy(SnowFX);
        }
    }

    public void DestroyAllFabricatedObjects()
    {
        StartCoroutine(OneAtATimeDestruction());
    }

    IEnumerator OneAtATimeDestruction()
    {
        float intervalTime = destructionTime / spawnedFabrications.Count;
        foreach(GameObject fab in spawnedFabrications)
        {
            Instantiate(destructionPrefabFX, fab.transform.position, fab.transform.rotation);
            Destroy(fab);
            yield return new WaitForSeconds(intervalTime);
        }
        spawnedFabrications.Clear();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
