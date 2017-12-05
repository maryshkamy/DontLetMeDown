using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class Environment : MonoBehaviour {

//    #region Public Property(ies).

//    public bool hasRigidbody = false;
//    public float lifeTime = 5.0f;

//    #endregion

//    #region Private Property(ies).

//    [SerializeField]
//    private Vector3 velocity = Vector3.zero;

//    #endregion

//    #region Public Property(ies).

//    private void Start() {
//        if (this.hasRigidbody) {
//            Rigidbody2D rigidbody = this.gameObject.AddComponent<Rigidbody2D>();
//            rigidbody.gravityScale = 0;
//        }

//        if (this.lifeTime > 0) {
//            StartCoroutine(this.autoDestroy());
//        }
//    }

//    private void Update() {
//        this.transform.position += (this.velocity * Time.deltaTime);
//    }

//    private IEnumerator autoDestroy() {
//        while(true) {
//            yield return new WaitForSeconds(this.lifeTime);
//            Destroy(this);
//        }
//    }

//    #endregion
//}
