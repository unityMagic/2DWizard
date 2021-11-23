using UnityEngine;
public class MovePanelUP : MonoBehaviour
{
	public float A =0 ;
	public float B =0;
	public float C = 0;
	public float SPEED = 0;
	void Update()
	{
		transform.Translate(0, SPEED, 0);
		
		if (transform.position.y > A)
		{
			transform.position = new Vector3(C, B, 0);
		}
	}
}
