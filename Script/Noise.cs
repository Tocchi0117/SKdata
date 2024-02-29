using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Noise : MonoBehaviour
{
    bool flag, flag1, flag2, flag3, flag4, flag5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (300 < MovieControll.FrameCount && MovieControll.FrameCount <= 400 && !flag)
        {
            Sound_SE.AudioStop();
            Sound_SE.Suzume();
            flag = true;
        }
        if (500 < MovieControll.FrameCount && MovieControll.FrameCount <= 600 && !flag1)
        {
            Sound_SE.AudioStop();
            Sound_SE.Sairen();
            flag = true;
        }
        if (1500 < MovieControll.FrameCount && MovieControll.FrameCount <= 1700 && !flag2)
        {
            Sound_SE.AudioStop();
            Sound_SE.Engin();
            flag = true;
        }
        if (3200 < MovieControll.FrameCount && MovieControll.FrameCount <= 3500 && !flag3)
        {
            Sound_SE.AudioStop();
            Sound_SE.Karasu();
            flag = true;
        }
        if (4200 < MovieControll.FrameCount && MovieControll.FrameCount <= 4400 && !flag4)
        {
            Sound_SE.AudioStop();
            Sound_SE.Heri();
            flag = true;
        }
        if (5200 < MovieControll.FrameCount && MovieControll.FrameCount <= 5600 && !flag5)
        {
            Sound_SE.AudioStop();
            Sound_SE.Karasu_long();
            flag = true;
        }
    }
}
