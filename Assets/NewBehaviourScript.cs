using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {




	// Use this for initialization
	void Start () {


		
	}
	
	// Update is called once per frame
	void Update () {



	}

	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "CarTag" || other.gameObject.tag == "ConeTag"){
			Destroy (other.gameObject);
		}
		if(other.gameObject.tag == "GoalTag"){
			Destroy (other.gameObject);
		}
		if (other.gameObject.tag == "CoinTag") {
			Destroy (other.gameObject);
		}
	}
}
