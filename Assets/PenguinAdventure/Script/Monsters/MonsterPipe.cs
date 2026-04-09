using UnityEngine;

public class MonsterPipe : MonoBehaviour {
	void OnCollisionEnter2D(Collision2D other){
			if (other.gameObject.CompareTag ("Player")) {
			GameManager.instance.GameOver ();
			}
	}
}
