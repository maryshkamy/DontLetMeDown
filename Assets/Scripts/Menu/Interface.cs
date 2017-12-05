using UnityEngine;
using UnityEngine.UI;

public class Interface : MonoBehaviour {

    [SerializeField]
    private Text Gold;
	
	void Update () {
        this.Gold.text = AppEnvironment.Shared.Environment.Gold.ToString();
	}
}
