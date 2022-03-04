using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public string nextSceneName;

    void OnMouseDown() {
        SceneManager.LoadScene(nextSceneName);
    }
}
