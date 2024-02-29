using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// ����𐧌䂷�邽�߂̖��O�̈�
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
        //�Đ�
        videoPlayer.Play();
        //�ꎞ��~
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
            //��~
            videoPlayer.Stop();
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            //�ꎞ��~
            videoPlayer.Pause();
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            //�Đ�
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


    // �V�[�N
    // <param name="frameIndex">��΂������t���[��</param>
    public void Seek(int frameIndex)
    {
        if (frameIndex > 0 && frameIndex <= (int)videoPlayer.frameCount)
        {
            videoPlayer.frame = frameIndex;
        }
    }


    // �R�}����
    public void ForwardFrame()
    {
        // �O�̂��߈ꎞ��~
        videoPlayer.Pause();

        var currentFrame = (int)videoPlayer.frame;

        // �t���[���̐������̓V�[�N�̊֐��ōs��
        Seek(currentFrame + Frame);
    }

    // �R�}�߂�
    public void BackFrame()
    {
        // �O�̂��߈ꎞ��~
        videoPlayer.Pause();

        var currentFrame = (int)videoPlayer.frame;

        // �t���[���̐������̓V�[�N�̊֐��ōs��
        Seek(currentFrame - Frame);
    }
}
