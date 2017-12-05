using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {
    #region Private Property(ies).

    [SerializeField]
    private List<GameObject> _Prefabs = new List<GameObject>();

    [SerializeField]
    private GameObject Instatiated;

    #endregion

    #region Public Property(ies).

    public ObstacleType ObstacleType = ObstacleType.NonObstacle;

    #endregion

    #region Unity Method(s).

    private void Start()
    { }

    #endregion

    #region Public Method(s).

    public IEnumerator InstantiateObject() {
        while(true) {
            if (AppEnvironment.Shared.Environment.IsStart) {
                if (this._Prefabs.Count > 0)
                {
                    this.Instatiated = this._Prefabs[UnityEngine.Random.Range(0, _Prefabs.Count)];
                    GameObject obj = GameObject.Instantiate(this.Instatiated);
                    obj.transform.position = ObstacleType == ObstacleType.NonObstacle ?
                        AppEnvironment.Shared.Environment.SpawnNonObstaclePoint.transform.position :
                        AppEnvironment.Shared.Environment.SpawnObstaclePoint.transform.position;

                    AppEnvironment.Shared.Environment.Obstacles.Add(obj);
                }

                yield return new WaitForSeconds(ObstacleType == ObstacleType.NonObstacle ?
                                                AppEnvironment.Shared.Environment.SpawnNonObstaclesTime :
                                                AppEnvironment.Shared.Environment.SpawnObstaclesTime);
            } else {
                yield return new WaitForSeconds(1);
            }
        }
    }

    #endregion
}
