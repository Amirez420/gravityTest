using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		transform.rotation = Quaternion.Euler(0,0,180 );
		Physics.gravity = new Vector3 (0, 9.81f, 0);

	}
	
	// Update is called once per frame
	void Update(){

}
}