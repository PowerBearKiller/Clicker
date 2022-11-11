using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneController : MonoBehaviour
{
    public void SceneChanger(int _sceneNum)
    {
      SceneManager.LoadScene(_sceneNum);
    }
}
