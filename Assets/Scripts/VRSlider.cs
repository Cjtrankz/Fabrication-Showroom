using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRSlider : MonoBehaviour
{
    ConfigurableJoint joint;
    Transform zeroPosition;
    public float sliderValue;
    float maxDistance;
    public float minValue, maxValue;

    // Start is called before the first frame update
    void Start()
    {
        joint = GetComponent<ConfigurableJoint>();
        maxDistance = joint.linearLimit.limit * 2;

        zeroPosition = new GameObject("SliderZeroPosition").transform;
        zeroPosition.position = transform.position - joint.axis * joint.linearLimit.limit;
        zeroPosition.parent = transform.parent;
    }

    // Update is called once per frame
    void Update()
    {
        float betweenZeroAndOne = (transform.position - zeroPosition.position).magnitude / maxDistance;
        sliderValue = minValue + betweenZeroAndOne * (maxValue - minValue);
        Debug.Log("slider value is: " + sliderValue);
    }
}
