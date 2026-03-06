using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Loading : MonoBehaviour
{
    [SerializeField] private Image m_image;
    private string _nameScene;
    public void LoadScene(string sceneName)
    {
        gameObject.SetActive(true);
        StartCoroutine(LoadSceneAsync(sceneName));
    }
    private IEnumerator LoadSceneAsync(string sceneName)
    {
        gameObject.SetActive(true);
        m_image.fillAmount = 0;
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneName);
        var delta = 1 - m_image.fillAmount;
        const int steps = 10;
        for (var i = 0; i<10; i++)
        {

            yield return new WaitForSeconds(0.5f);
            m_image.fillAmount += delta/ steps;

        }
        yield return null;
    }

}
