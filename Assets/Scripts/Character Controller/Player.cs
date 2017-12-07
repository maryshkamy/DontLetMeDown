using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
        Setup();
        Jump();
        Pause();
    }

    private void Setup()
    {
        if (AppEnvironment.Shared.Environment.IsStart)
        {
            this.GetComponent<Rigidbody2D>().gravityScale = 2;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "Portal")
        {
            AppEnvironment.Shared.Environment.IsPaused = !AppEnvironment.Shared.Environment.IsPaused;
            AppEnvironment.Shared.TimerText.gameObject.SetActive(true);
            AppEnvironment.Shared.TimerText.text = "Game Over";
            AppEnvironment.Shared.Reload.GetComponent<Button>().enabled = true;
            AppEnvironment.Shared.Reload.GetComponent<Image>().enabled = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Portal")
        {
            AppEnvironment.Shared.Environment.Gold += 1;
        }
    }

    private static void Pause()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            AppEnvironment.Shared.Environment.IsPaused = !AppEnvironment.Shared.Environment.IsPaused;
        }
    }

    private void Jump()
    {
        if (Input.GetKeyUp(this.JumpKey) && this.transform.position.y <= 4 && AppEnvironment.Shared.Environment.IsStart)
        {
            this.Rigidbody.velocity = Vector2.zero;
            this.Rigidbody.AddForce(this.JumpForce);
        }
    }
}
