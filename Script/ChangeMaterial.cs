using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    public const int N = 7;
    [SerializeField] Material[] materialArray = new Material[N];
    Material cubeMaterial;
    private int count;

    void Start()
    {
        count = 0;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            count++;
            if (count > materialArray.Length - 1)
            {
                count = 0;
            }

            GetComponent<MeshRenderer>().material = materialArray[count];
        }

        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            count--;
            if (count < 0)
            {
                count = materialArray.Length - 1;
            }

            GetComponent<MeshRenderer>().material = materialArray[count];
        }
    }
}