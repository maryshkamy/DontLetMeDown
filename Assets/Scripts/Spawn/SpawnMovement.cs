using UnityEngine;

public class SpawnMovement : MonoBehaviour {
    #region Public Method(s).

    public void Move(GameObject obj, float velocity) {
        obj.transform.position += new Vector3(-velocity, 0, 0);
    }

    #endregion
}
