using UnityEngine;
using UnityEngine.UI;

public class Interface : MonoBehaviour
{

    [SerializeField]
    private Text Gold;

    [SerializeField]
    private int Score;

	void Update ()
    {
        this.Gold.text = AppEnvironment.Shared.Environment.Gold.ToString();

        if(AppEnvironment.Shared.Environment.Gold == this.Score)
        {
            Debug.Log(Application.loadedLevel);
            if (Application.loadedLevel == 5)
            {
                Application.LoadLevel(0);
            } else {
				Application.LoadLevel(Application.loadedLevel + 1);
            }
        }
	}
}
