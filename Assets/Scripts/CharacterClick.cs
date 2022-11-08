using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CharacterClick : MonoBehaviour, IPointerDownHandler
{
    public GameObject refObj;
    public bool doEnable;
    public float newTimeScale;

    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        refObj.SetActive(doEnable);
        Time.timeScale = newTimeScale;
    }

    public void OnPointerDown(PointerEventData data)
    {
        OnClick();
    }
}
