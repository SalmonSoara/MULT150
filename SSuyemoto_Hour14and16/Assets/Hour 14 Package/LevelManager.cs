using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
	public string sceneToLoad = "Game";
    public string sceneToInstruct = "Instructions";
    public string sceneToMenu = "ssuyemoto_Hour14";

    public void LoadGame ()
	{
		SceneManager.LoadScene(sceneToLoad);
	}

    public void LoadInstructions()
    {
        SceneManager.LoadScene(sceneToInstruct);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(sceneToMenu);
    }
}
