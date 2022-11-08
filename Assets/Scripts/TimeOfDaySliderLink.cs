using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeOfDaySliderLink : MonoBehaviour
{
    public VRSlider linkedSlider;
    Light sunLight;
    public AnimationCurve lightIntensity;
    public Gradient lightColor;


    // Start is called before the first frame update
    void Start()
    {
        sunLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
            Quaternion newRotation = Quaternion.Euler(linkedSlider.sliderValue, transform.rotation.y, transform.rotation.z);
            transform.rotation = newRotation;

            float betweenZeroAndOne = (linkedSlider.sliderValue - linkedSlider.minValue) / (linkedSlider.maxValue - linkedSlider.minValue);
            sunLight.intensity = lightIntensity.Evaluate(betweenZeroAndOne);
            sunLight.color = lightColor.Evaluate(betweenZeroAndOne);
    }
}
