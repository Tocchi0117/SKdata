using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Q_A : MonoBehaviour
{
    public GameObject QPanel;
    public GameObject APanel;
    public GameObject[] Truth;
    public GameObject[] Lie;
    public Text Lv;

    public Text[] Answer;
    public int[] memo0;
    public int[] memo1;
    public int[] memo2;
    public int[] memo3;
    public int[] memo4;
    int[] num;
    bool success;
    string tmp;

    // Start is called before the first frame update
    void Start()
    {
        QPanel.SetActive(true);
        APanel.SetActive(false);
        num = new int[Answer.Length];
        tmp = Lv.text;
        Lv.text += "Lv.2";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            APanel.SetActive(!APanel.activeSelf);
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            QPanel.SetActive(!QPanel.activeSelf);
        }
    }

    public void OK()
    {
        QPanel.SetActive(false);
    }

    public void Ans()
    {
        success = true;
        for (int i = 0; i < Answer.Length; i++){
            num[i] = int.Parse(Answer[i].text);
        }

        keisan();

        if (success)
        {
            Debug.Log("おめでとう！正解です！");
        }
        else
        {
            Debug.Log("残念...不正解です。");
        }
    }

    void keisan()
    {
        switch (LoadText.TA.name)
        {
            case "パターン0":
                kaiten(memo0);
                break;
            case "パターン1":
                kaiten(memo1);
                break;
            case "パターン2":
                kaiten(memo2);
                break;
            case "パターン3":
                kaiten(memo3);
                break;
            case "パターン4":
                kaiten(memo4);
                break;
        }
    }

    void kaiten(int[] num_ans)
    {
        for (int i = 0; i < Answer.Length; i++)
        {
            if (num_ans[i] != num[i])
            {
                success = false;
            }
        }
    }

    public void E_Mode()
    {
        Lv.text = tmp;

        for (int i = 0; i < Truth.Length; i++)
        {
            Truth[i].SetActive(false);
        }
        for (int i = 0; i < Lie.Length; i++)
        {
            Lie[i].SetActive(false);
        }

        switch (LoadText.TA.name)
        {
            case "パターン0":
                Truth[1].SetActive(true);
                Truth[6].SetActive(true);
                Truth[7].SetActive(true);
                Truth[13].SetActive(true);
                Truth[10].SetActive(true);
                break;
            case "パターン1":
                Truth[0].SetActive(true);
                Truth[15].SetActive(true);
                Truth[14].SetActive(true);
                Truth[8].SetActive(true);
                Truth[11].SetActive(true);
                break;
            case "パターン2":
                Truth[3].SetActive(true);
                Truth[10].SetActive(true);
                Truth[8].SetActive(true);
                Truth[13].SetActive(true);
                break;
            case "パターン3":
                Truth[9].SetActive(true);
                Truth[13].SetActive(true);
                Truth[15].SetActive(true);
                Truth[4].SetActive(true);
                break;
            case "パターン4":
                Truth[2].SetActive(true);
                Truth[5].SetActive(true);
                Truth[12].SetActive(true);
                break;
        }

        Lv.text += "Lv.1";
    }

    public void N_Mode()
    {
        Lv.text = tmp;

        for (int i = 0; i < Truth.Length; i++)
        {
            Truth[i].SetActive(true);
        }
        for (int i = 0; i < Lie.Length; i++)
        {
            Lie[i].SetActive(false);
        }

        Lv.text += "Lv.2";
    }

    public void H_Mode()
    {
        Lv.text = tmp;

        for (int i = 0; i < Truth.Length; i++)
        {
            Truth[i].SetActive(true);
        }
        for (int i = 0; i < Lie.Length; i++)
        {
            Lie[i].SetActive(true);
        }

        Lv.text += "Lv.3";
    }
}
