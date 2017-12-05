using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Environment
{
    #region Public Property(ies).

    public List<GameObject> Obstacles;
    public float ObstacleTimeToDestroy = 5.0f;
    public float ObstaclesVelocity = 0.5f;
    public float SpawnObstaclesTime = 1.0f;

    public float NonObstacleTimeToDestroy = 5.0f;
    public float NonObstaclesVelocity = 0.5f;
    public float SpawnNonObstaclesTime = 1.0f;

    public Transform SpawnObstaclePoint;
    public Transform SpawnNonObstaclePoint;
    public int Gold = 0;
    public bool IsStart = false;

    public bool IsPaused { 
        get {
            return _IsPaused;
        }
        set {
            AppEnvironment.Shared.GetComponent<Pause>().execute();
            this._IsPaused = value;
        }
    }

    #endregion

    #region Private Property(ies) 

    private bool _IsPaused = false;

    #endregion

    #region Constructor(s).

    public Environment() {
        this.Obstacles = new List<GameObject>();
    }

    #endregion
}
