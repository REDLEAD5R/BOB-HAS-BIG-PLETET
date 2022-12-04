using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class SceneChange : MonoBehaviour
{
    // Start is called before the first frame update
    public string sceneName;

    // Update is called once per frame
    void OnTriggerEnter()
    {
        //Перезапуск сцены
        EditorSceneManager.LoadScene(sceneName);
    }
}
