using UnityEngine;

public class Player : MonoBehaviour 
{
	private Rigidbody2D Rigidbody;
    public KeyCode JumpKey = KeyCode.Space;
    public Vector2 JumpForce = new Vector2(0, 300);

	private void Start () 
    {
        this.Rigidbody = this.GetComponent<Rigidbody2D>();
	}
	
	private void Update () 
    {
        if (Input.GetKeyUp(this.JumpKey)) 
        {
            this.Rigidbody.velocity = Vector2.zero;
            this.Rigidbody.AddForce(this.JumpForce);
        }
	}
}
