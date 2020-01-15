using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour
{
    public GameObject LoadingScreen;
    public Slider Slider;
    public void LoadLevel(int sceneIndex)
    {
        StartCoroutine(LoadAsynchronosly(sceneIndex));
    }

    IEnumerator LoadAsynchronosly (int SceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(SceneIndex);
        
        LoadingScreen.SetActive(true);
        
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            Debug.Log(progress);
            Slider.value = progress;
            yield return null;
        }
    }
}
