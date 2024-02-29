using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P_M : MonoBehaviour
{
    public Text text;
    int num;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = num.ToString();
    }

    public void P()
    {
        if (num < 1000)
        {
            num++;
        }
    }
    public void M()
    {
        if (num > 0)
        {
            num--;
        }
    }
}
