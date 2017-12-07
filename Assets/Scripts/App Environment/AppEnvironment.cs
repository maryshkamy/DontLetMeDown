using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class AppEnvironment : MonoBehaviour
{
    #region Design Pattern: Singleton 

    public static AppEnvironment Shared;

    #endregion

    #region Public Property(ies).

    public Environment Environment;
    public Text TimerText;

    #endregion

    #region Private Property(ies).

    private SpawnMovement _SpawnMovement;
    private Spawn _ObstaclesSpawn;
    private Spawn _NonObstaclesSpawn;

    #endregion

    #region Unity Method(s).

    private void Start()
    {
        AppEnvironment.Shared = this;
        this._SpawnMovement = this.GetComponent<SpawnMovement>();
        this.SetupObstacles(GetComponents<Spawn>().ToList());
        this.SetupNonObstacles(GetComponents<Spawn>().ToList());
        StartCoroutine(this.Timer(3));

    }

    private void Update() {
        if (this._SpawnMovement)
        {
            foreach (var obj in this.Environment.Obstacles)
            {
                this._SpawnMovement.Move(obj, this.Environment.ObstaclesVelocity * Time.deltaTime);
            }
        }
    }

    #endregion

    #region Private Method(s).

    private void SetupObstacles(List<Spawn> spawners)
    {
        this._ObstaclesSpawn = (from s in spawners
                                where s.ObstacleType == ObstacleType.Obstacle
                                select s).Single();

        StartCoroutine(this._ObstaclesSpawn.InstantiateObject());
    }

    private void SetupNonObstacles(List<Spawn> spawners)
    {
        this._NonObstaclesSpawn = (from s in spawners
                                   where s.ObstacleType == ObstacleType.NonObstacle
                                   select s).Single();

        StartCoroutine(this._NonObstaclesSpawn.InstantiateObject());
    }

    private IEnumerator Timer(int value)
    {
        while(true)
        {
            for (int i = value; i >= 0; i--)
            {
                yield return new WaitForSeconds(1);
                this.TimerText.text = i.ToString();
            }

            Environment.IsStart = true;
            this.TimerText.gameObject.SetActive(false);
            StopCoroutine("Timer");
        }
    }

    #endregion
}
