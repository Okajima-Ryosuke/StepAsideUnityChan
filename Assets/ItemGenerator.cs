using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour {

	public GameObject carPrefab;
	public GameObject coinPrefab;
	public GameObject conePrefab;
	private int startPos = -160;
	private int goalPos = 120;
	private float posRange = 3.4f;
	private int zpos = -115;
	public GameObject UnitySama;

	// Use this for initialization
	void Start () {

		UnitySama = GameObject.Find ("unitychan");

		for (int i = startPos; i < startPos + 45 ; i += 15) {
			int num = Random.Range (1, 11);
			if (num <= 2) {
				for (float j = -1; j <= 1; j += 0.4f) {
					GameObject cone = Instantiate (conePrefab) as GameObject;
					cone.transform.position = new Vector3 (4 * j, cone.transform.position.y, i);
				}
			} else {
				for (int j = -1; j <= 1; j++) {
					int item = Random.Range (1, 11);
					int offsetZ = Random.Range (-5, 6);
					if (1 <= item && item <= 6) {
						GameObject coin = Instantiate (coinPrefab) as GameObject;
						coin.transform.position = new Vector3 (posRange * j, coin.transform.position.y, i + offsetZ);
					} else if (7 <= item && item <= 9) {
						GameObject car = Instantiate (carPrefab) as GameObject;
						car.transform.position = new Vector3 (posRange * j, car.transform.position.y, i + offsetZ);
					}
				}
			}
		}
	}

	// Update is called once per frame
	// ユニティ様の45メートル先から　15メートル毎に　ゴール地点まで　アイテム生成
	void Update () {
		int UnitySamaZ = (int)UnitySama.transform.position.z;
		if (UnitySamaZ + 45 == zpos && UnitySamaZ + 45 < goalPos) {
			int num = Random.Range (1, 11);
			if (num <= 2) {
				for (float j = -1; j <= 1; j += 0.4f) {
					GameObject cone = Instantiate (conePrefab) as GameObject;
					cone.transform.position = new Vector3 (4 * j, cone.transform.position.y, zpos);
				}
			} else {
				for (int j = -1; j <= 1; j++) {
					int item = Random.Range (1, 11);
					int offsetZ = Random.Range (-5, 6);
					if (1 <= item && item <= 6) {
						GameObject coin = Instantiate (coinPrefab) as GameObject;
						coin.transform.position = new Vector3 (posRange * j, coin.transform.position.y, zpos + offsetZ);
					} else if (7 <= item && item <= 9) {
						GameObject car = Instantiate (carPrefab) as GameObject;
						car.transform.position = new Vector3 (posRange * j, car.transform.position.y, zpos + offsetZ);
					}
				}
			}
			zpos += 15;
		}
	}
}