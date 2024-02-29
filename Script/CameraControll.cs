using System.Collections.Generic;
using UnityEngine;

public class CameraControll : MonoBehaviour
{
    //回転の速さ
    public float rotateSpeed = 2.0f;

    public float x, y;

    //呼び出し時に実行される関数
    void Start()
    {

    }


    //単位時間ごとに実行される関数
    void Update()
    {
        rotateCamera();
    }

    //カメラを回転させる関数
    private void rotateCamera()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            x += Time.deltaTime * Input.GetAxis("Mouse Y") * rotateSpeed;
            y += Time.deltaTime * Input.GetAxis("Mouse X") * rotateSpeed;
            transform.rotation = Quaternion.Euler(x, y, 0);
        }
    }
}