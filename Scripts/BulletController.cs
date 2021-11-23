using UnityEngine;
using System.Collections;
public class BulletController : MonoBehaviour{
	void Update(){
		transform.Translate(0.5f, 0f, 0);
		if (transform.position.y > 50)
		{
			Destroy(gameObject);
		}
	}
}
