using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadScene : MonoBehaviour
{
    Scene scene;
    public GameObject gameOverPanel;

    private void Start()
    {
        scene = SceneManager.GetActiveScene();
    }

    public void ReloadSceneMethod()
    {
        //SceneManager.LoadScene(scene.name);
        //gameOverPanel.GetComponent<RectTransform>().position = new Vector3(-1000, -2000, 0);
        GetComponent<StartOperations>().StartMethod();
        SceneManager.LoadScene(scene.buildIndex);
    }
}
