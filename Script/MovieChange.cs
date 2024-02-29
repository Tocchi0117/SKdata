using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class MovieChange : MonoBehaviour
{
    [SerializeField] VideoPlayer videoPlayer;
    [SerializeField] VideoClip[] VC;

    int num;
    bool flag;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O) && num != VC.Length - 1)
        {
            num++;
            flag = true;
        }
        if (Input.GetKeyDown(KeyCode.I) && num != 0)
        {
            num--;
            flag = true;
        }

        if (flag)
        {
            videoPlayer.clip = VC[num];
            //çƒê∂
            videoPlayer.Play();
            //àÍéûí‚é~
            videoPlayer.Pause();
            flag = false;
        }
    }
}
