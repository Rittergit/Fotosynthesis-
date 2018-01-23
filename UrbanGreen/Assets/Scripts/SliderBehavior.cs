using UnityEngine;
using System.Collections;

public class SliderBehavior: MonoBehaviour
{
    public RadialMultiValueSlider slider;
    public GameObject lamp;
    void OnGUI()
    {
        var firstElement = slider.values[0].val;
        var secondElement = slider.values[1].val;

        if (slider.isdragged)
        {
            lamp.transform.eulerAngles = new Vector3(secondElement * 360,firstElement * 360,0);
        }

    }
}
