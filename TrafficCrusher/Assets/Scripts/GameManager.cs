using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] LevelPrefabs;
    public GameObject currentLevelObject;
    public GameObject nextLevelObject;
    public int currentLevel;
    public int nextLevel;
    public GameObject gameOverPanel;


    private void Awake()
    {
        GameEssentials.isGameBeingPlayed = false;
    }
    private void Start()
    {
       nextLevelObject.transform.position = Vector3.left * 100 + currentLevelObject.GetComponent<LevelInfo>().connectionPointEnd.transform.position;
        LerpNextLevel();
    }

    private void Update()
    {
        if (!GameEssentials.isGameBeingPlayed && Time.timeScale == 1f)
            Time.timeScale = 0f;
        else if (GameEssentials.isGameBeingPlayed && Time.timeScale == 0f)
            Time.timeScale = 1f;
        if(GameEssentials.isGameOver)
        {
            gameOverPanel.GetComponent<RectTransform>().position = new Vector3(540, 960, 0);
        }
    }

    public void GetNextLevel() // standart
    {
        Destroy(currentLevelObject,2.5f);
        currentLevelObject = nextLevelObject;
        currentLevel = nextLevel;
        //nextLevel = (nextLevel + 1) % LevelPrefabs.Length;
        nextLevel = Random.Range(0, LevelPrefabs.Length);

        Vector3 spawnPos = Vector3.left * 100 + currentLevelObject.GetComponent<LevelInfo>().connectionPointEnd.transform.position;
        nextLevelObject = Instantiate(LevelPrefabs[nextLevel], spawnPos, Quaternion.identity);
        LerpNextLevel();
    }

    public void LerpNextLevel()
    {
        Vector3 offset = nextLevelObject.GetComponent<LevelInfo>().connectionPointStart.transform.position - nextLevelObject.transform.position;
        //nextLevelObject.transform.position = currentLevelObject.GetComponent<LevelInfo>().connectionPointEnd.transform.position - offset;
        LeanTween.move(nextLevelObject, currentLevelObject.GetComponent<LevelInfo>().connectionPointEnd.transform.position - offset, .2f);
    }
}
