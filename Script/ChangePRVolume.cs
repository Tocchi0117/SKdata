using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class ChangePRVolume : MonoBehaviour
{
    public GameObject canvas;
    public Slider sliderA;
    public Slider sliderF;

    public Text textA;
    public Text textF;

    public int Amax;
    public int Fmax;
    int min = 0;

    void Start()
    {
        sliderA.maxValue = Amax;
        sliderA.minValue = min;
        sliderA.value = PlayerPrefs.GetInt("Volume_A");
        textA.text = (1 + (sliderA.value / 10)).ToString();

        sliderF.maxValue = Fmax;
        sliderF.minValue = min;
        sliderF.value = PlayerPrefs.GetInt("Volume_F");
        textF.text = sliderF.value.ToString();

        canvas.SetActive(false);
    }

    void Update()
    {
        //Debug.Log("AHIBUMIËáíl = " + (1 + (float)PlayerPrefs.GetInt("Volume_A") / 10));
        //Debug.Log("SkipFrameêî = " + PlayerPrefs.GetInt("Volume_F"));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            canvas.SetActive(!canvas.activeSelf);
            sliderA.Select();
        }
    }

    public void SoundSliderOnValueChangeA(float newSliderValueA)
    {
        PlayerPrefs.SetInt("Volume_A", (int)newSliderValueA);
        PlayerPrefs.Save();
        sliderA.value = PlayerPrefs.GetInt("Volume_A");
    }

    public void SoundSliderOnValueChangeF(float newSliderValueF)
    {
        PlayerPrefs.SetInt("Volume_F", (int)newSliderValueF);
        PlayerPrefs.Save();
        sliderF.value = PlayerPrefs.GetInt("Volume_F");
    }


    public void SliderText()
    {
        textA.text = (1 + (sliderA.value / 10)).ToString();
        textF.text = sliderF.value.ToString();
    }
}
