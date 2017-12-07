using UnityEngine;
using UnityEngine.SceneManagement;

public class CheatCode : MonoBehaviour
{
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SceneManager.LoadScene(1);
            Time.timeScale = 1;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SceneManager.LoadScene(2);
            Time.timeScale = 1;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SceneManager.LoadScene(3);
            Time.timeScale = 1;
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            SceneManager.LoadScene(4);
            Time.timeScale = 1;
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            SceneManager.LoadScene(5);
            Time.timeScale = 1;
        }
	}
}
