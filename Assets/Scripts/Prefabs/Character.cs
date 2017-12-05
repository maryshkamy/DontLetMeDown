using UnityEngine;

public class Character : MonoBehaviour
{
    #region Public Property(ies)

    public Vector2 Force;

    #endregion

    #region Private Property(ies)

    [SerializeField]
    private KeyCode Key = KeyCode.Space;

    [SerializeField]
    private Rigidbody2D Rigidbody;

    #endregion

    #region Unity Function(s).

    void Start()
    {
        this.Rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyUp(this.Key))
        {
            this.Rigidbody.AddForce(this.Force);
        }
    }

    #endregion
}
