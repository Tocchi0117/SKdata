using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;

public class RealtimeCsPy : MonoBehaviour
{

    Process pr = null;

    // Start is called before the first frame update
    void Start()
    {
        HeavyMethod();
    }

    /// <summary>
    /// python�R�[�h��񓯊��Ŏ��s
    /// <summary>
    public void HeavyMethod()
    {
        pr = new Process();

        //C:/Users/�g�b�`/Desktop/���낢��/�ۑ�/���ƌ���/SK/Assets/Movie/360_test2.MP4
        //C:\Users\�g�b�`\Documents\PlatformIO\Projects\wifi-accel3-O\src\Receive.py>

        //myPC
        /*
        // python�t�@�C���̎w��
        pr.StartInfo.FileName = @"C:\anaconda\python.exe";
        // ���s������python�̃R�[�h���w��
        pr.StartInfo.Arguments = @" -u C:\Users\�g�b�`\Documents\PlatformIO\Projects\wifi-accel3-O\src\Receive.py";
        */

        //���쌤-�Q�[���v���W�F�N�gPC_A
        /*
        // python�t�@�C���̎w��
        pr.StartInfo.FileName = @"C:\anaconda3\python.exe";
        // ���s������python�̃R�[�h���w��
        pr.StartInfo.Arguments = @" -u C:\Users\mutsuo.sano\Desktop\SK\Receive.py";
        */

        // python�t�@�C���̎w��
        pr.StartInfo.FileName = @"C:\anaconda3\python.exe";
        // ���s������python�̃R�[�h���w��
        pr.StartInfo.Arguments = @" -u C:\Users\mutsuo.sano\Desktop\SK\Receive.py";

        // �R���\�[����ʂ�\�������Ȃ�
        pr.StartInfo.CreateNoWindow = true;

        // �񓯊����s�ɕK�v
        pr.StartInfo.UseShellExecute = false;
        pr.StartInfo.RedirectStandardOutput = true;

        // �C�x���g�n���h���o�^�i�W���o�͎��j
        pr.OutputDataReceived += process_DataReceived;

        // �C�x���g�n���h���o�^�i�v���Z�X�I�����j
        pr.EnableRaisingEvents = true;

        pr.Start();
        pr.BeginOutputReadLine(); //�񓯊��ŕW���o�͓ǂݎ��
    }

    /// <summary>
    /// �W���o�͂����������Ɏ��s
    /// </summary>
    public void process_DataReceived(object sender, DataReceivedEventArgs e)
    {
        string output = e.Data + "\r\n";

        //print(output);

        if (!MovieControll.ASHIBUMI)
        {
            PrintMasic.BOKENASU = output;
        }
    }

}