using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//シーン切り替えに使用するライブラリ
using UnityEngine.SceneManagement;

public class tmp : MonoBehaviour
{

    [SerializeField] private string IDOUsaki;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
      Application.Quit();
#endif
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Backspace))
        {
            Application.Quit();
            Debug.Log("終了できてない");
        }


        //移動
        if (Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene(IDOUsaki, LoadSceneMode.Single);
        }
    }
}
