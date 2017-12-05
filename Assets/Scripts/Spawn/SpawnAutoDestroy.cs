using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAutoDestroy : MonoBehaviour
{
    #region Private Property(ies).

    private ObstacleType _ObstacleType = ObstacleType.Obstacle;

    #endregion

    #region Unity Method(s).

    private void Start()
    {
        StartCoroutine(this.AutoDestroy());
    }

    #endregion

    #region Private Method(s).

    private IEnumerator AutoDestroy()
    {
        while (true)
        {
            yield return new WaitForSeconds(this._ObstacleType == ObstacleType.Obstacle ?
                                            AppEnvironment.Shared.Environment.ObstacleTimeToDestroy :
                                            AppEnvironment.Shared.Environment.NonObstacleTimeToDestroy);

            AppEnvironment.Shared.Environment.Obstacles.Remove(this.gameObject);
            DestroyImmediate(this.gameObject);
        }
    }

    #endregion
}
