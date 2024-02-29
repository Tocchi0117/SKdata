using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 動画を制御するための名前領域
using UnityEngine.Video;

public class MovieControll : MonoBehaviour
{
    [SerializeField] VideoPlayer videoPlayer;
    [SerializeField] Text text;

    int Frame;

    public static bool ASHIBUMI;
    public static int FrameCount;

    // Start is called before the first frame update
    void Start()
    {
        //再生
        videoPlayer.Play();
        //一時停止
        videoPlayer.Pause();
    }

    // Update is called once per frame
    void Update()
    {
        if(PrintMasic.AHOKABOTYA > (1 + (float)PlayerPrefs.GetInt("Volume_A") / 10))
        {
            ASHIBUMI = true;
        }
        Frame = PlayerPrefs.GetInt("Volume_F");
        text.text = ((int)videoPlayer.frame).ToString();
        FrameCount= (int)videoPlayer.frame;


        if (Input.GetKeyDown(KeyCode.R))
        {
            //停止
            videoPlayer.Stop();
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            //一時停止
            videoPlayer.Pause();
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            //再生
            videoPlayer.Play();
        }




        if (Input.GetKey(KeyCode.K))
        {
            ASHIBUMI = true;
        }




        if (ASHIBUMI)
        {
            ForwardFrame();
            ASHIBUMI = false;
            PrintMasic.AHOKABOTYA = 0;
        }
        if (Input.GetMouseButton(1) || Input.GetKey(KeyCode.L))
        {
            BackFrame();
        }
        /*
        if (Input.GetMouseButton(2) || Input.GetKey(KeyCode.J))
        {
            Seek(Frame);
        }*/
    }


    // シーク
    // <param name="frameIndex">飛ばしたいフレーム</param>
    public void Seek(int frameIndex)
    {
        if (frameIndex > 0 && frameIndex <= (int)videoPlayer.frameCount)
        {
            videoPlayer.frame = frameIndex;
        }
    }


    // コマ送り
    public void ForwardFrame()
    {
        // 念のため一時停止
        videoPlayer.Pause();

        var currentFrame = (int)videoPlayer.frame;

        // フレームの整合性はシークの関数で行う
        Seek(currentFrame + Frame);
    }

    // コマ戻し
    public void BackFrame()
    {
        // 念のため一時停止
        videoPlayer.Pause();

        var currentFrame = (int)videoPlayer.frame;

        // フレームの整合性はシークの関数で行う
        Seek(currentFrame - Frame);
    }
}
