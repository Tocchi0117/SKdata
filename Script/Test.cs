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
    /// pythonコードを非同期で実行
    /// <summary>
    public void HeavyMethod()
    {
        pr = new Process();

        //C:/Users/トッチ/Desktop/いろいろ/課題/卒業研究/SK/Assets/Movie/360_test2.MP4
        //C:\Users\トッチ\Documents\PlatformIO\Projects\wifi-accel3-O\src\Receive.py>

        //myPC
        /*
        // pythonファイルの指定
        pr.StartInfo.FileName = @"C:\anaconda\python.exe";
        // 実行したいpythonのコードを指定
        pr.StartInfo.Arguments = @" -u C:\Users\トッチ\Documents\PlatformIO\Projects\wifi-accel3-O\src\Receive.py";
        */

        //佐野研-ゲームプロジェクトPC_A
        /*
        // pythonファイルの指定
        pr.StartInfo.FileName = @"C:\anaconda3\python.exe";
        // 実行したいpythonのコードを指定
        pr.StartInfo.Arguments = @" -u C:\Users\mutsuo.sano\Desktop\SK\Receive.py";
        */

        // pythonファイルの指定
        pr.StartInfo.FileName = @"C:\anaconda3\python.exe";
        // 実行したいpythonのコードを指定
        pr.StartInfo.Arguments = @" -u C:\Users\mutsuo.sano\Desktop\SK\Receive.py";

        // コンソール画面を表示させない
        pr.StartInfo.CreateNoWindow = true;

        // 非同期実行に必要
        pr.StartInfo.UseShellExecute = false;
        pr.StartInfo.RedirectStandardOutput = true;

        // イベントハンドラ登録（標準出力時）
        pr.OutputDataReceived += process_DataReceived;

        // イベントハンドラ登録（プロセス終了時）
        pr.EnableRaisingEvents = true;

        pr.Start();
        pr.BeginOutputReadLine(); //非同期で標準出力読み取り
    }

    /// <summary>
    /// 標準出力があった時に実行
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