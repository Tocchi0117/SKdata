using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrintMasic : MonoBehaviour
{
    public static string BOKENASU = "0";
    public static float AHOKABOTYA = 0;

    public Text otameshi;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AHOKABOTYA = float.Parse(BOKENASU);
        otameshi.text = BOKENASU;
        //Debug.Log("合成加速度 = " + BOKENASU + "(string)");
        //Debug.Log("合成加速度 = " + AHOKABOTYA + "(float)");
    }
}
