using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour {

	public GameObject carPrefab;

	public GameObject coinPrefab;

	public GameObject conePrefab;

	private float startPos = -160f;

	private float goalPos = 120f;

	private float posRange = 3.4f;

	private GameObject unitychan;
	private float IP;
	private float SP;
	private float time;

	// Use this for initialization
	void Start () {

		this.unitychan = GameObject.Find ("unitychan");
		this.IP = unitychan.transform.position.z + 40.0f;
		this.SP = unitychan.transform.position.z + 15.0f;

/*		for(int i = startPos; i < goalPos; i+=15){
			int num = Random.Range (0, 10);
			if (num <= 1) {
				for (float j = -1; j <= 1; j += 0.4f) {
					GameObject cone = Instantiate (conePrefab) as GameObject;
					cone.transform.position = new Vector3 (4 * j, cone.transform.position.y, i);
				}
			}else{
				for(int j = -1; j < 2 ; j++){
					int item = Random.Range (1,11);
					int offsetZ = Random.Range (-5, 6);
					if (1 <= item && item <= 6) {
						GameObject coin = Instantiate (coinPrefab) as GameObject;
						coin.transform.position = new Vector3 (posRange * j, coin.transform.position.y, i + offsetZ);
					}else if(7 <= item && item <= 9){
						GameObject car = Instantiate (carPrefab) as GameObject;
						car.transform.position = new Vector3 (posRange * j, car.transform.position.y, i + offsetZ);
						}
					}
				}
			}         */
	   }
	
	// Update is called once per frame
	void Update () {

	//if(unitychan.transform.position.z > IP){

	//	time -= Time.deltaTime;
	//		if (time <= 0.0){
	//			time = 1.5f;	

	//for (int i = startPos; i < goalPos; i+=15) {


		for(float i = unitychan.transform.position.z; i > SP ; SP += 15.0f){	
		

			int num = Random.Range (0, 10);
			if (num <= 1) {
				for (float j = -1; j <= 1; j += 0.4f) {
					GameObject cone = Instantiate (conePrefab) as GameObject;
						cone.transform.position = new Vector3 (4 * j, cone.transform.position.y, IP);
				}
			}else{
				for(int j = -1; j < 2 ; j++){
					int item = Random.Range (1,11);
					int offsetZ = Random.Range (-5, 6);
					if (1 <= item && item <= 6) {
						GameObject coin = Instantiate (coinPrefab) as GameObject;
							coin.transform.position = new Vector3 (posRange * j, coin.transform.position.y, IP);
					}else if(7 <= item && item <= 9){
						GameObject car = Instantiate (carPrefab) as GameObject;
							car.transform.position = new Vector3 (posRange * j, car.transform.position.y, IP);
					}
				}
			}
		//}
				IP =  unitychan.transform.position.z + 50.0f;
	}
}
}