using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour {

	public GameObject CoinClone;
	public GameObject ConeClone;
	public GameObject CarClone;

	// ユニティ様の後方15メートルのコインと障害物をデストロイする内容をこのファイルに書く
	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {

		CoinClone = GameObject.Find("CoinPrefab(Clone)");
		ConeClone = GameObject.Find ("TrafficConePrefab(Clone)");
		CarClone = GameObject.Find ("CarPrefab(Clone)");

		if (CoinClone && this.transform.position.z > CoinClone.transform.position.z) {
			Destroy (CoinClone);
		}
		if (ConeClone && this.transform.position.z > ConeClone.transform.position.z) {
			Destroy (ConeClone);
		}
		if (CarClone && this.transform.position.z > CarClone.transform.position.z) {
			Destroy (CarClone);
		}
	}
}
