using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMenu : MonoBehaviour {

    public GameObject panel;
    public GameObject slider;
    bool state = false;
    bool state2 = false;

    public void Start()
    {
        panel.gameObject.SetActive(false);
        slider.gameObject.SetActive(false);
    }

    public void SwitchShowHideMenu()
    {
            state2 = false;
            state = !state;
            panel.gameObject.SetActive(state);
            slider.gameObject.SetActive(state2);
    }

    public void showSlider()
    {
            state = false;
            state2 = !state2;
            slider.gameObject.SetActive(state2);
            panel.gameObject.SetActive(state);
    }
}
