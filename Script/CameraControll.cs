using System.Collections.Generic;
using UnityEngine;

public class CameraControll : MonoBehaviour
{
    //��]�̑���
    public float rotateSpeed = 2.0f;

    public float x, y;

    //�Ăяo�����Ɏ��s�����֐�
    void Start()
    {

    }


    //�P�ʎ��Ԃ��ƂɎ��s�����֐�
    void Update()
    {
        rotateCamera();
    }

    //�J��������]������֐�
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