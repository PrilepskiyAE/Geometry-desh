using UnityEngine;
using UnityEngine.SceneManagement;

public class NavigationSystem : MonoBehaviour
{

   public void LoadLevel(int levelIndex)
    {

        SceneManager.LoadScene(levelIndex);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void NextLevel()
    {
            SceneManager.LoadScene(0);

    }

    public string getName() {  return SceneManager.GetActiveScene().name;}
}
