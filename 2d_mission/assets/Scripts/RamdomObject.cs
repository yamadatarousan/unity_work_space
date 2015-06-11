using UnityEngine;
using System.Collections;

public class RamdomObject : MonoBehaviour {

    //プレハブを変数に代入
    public GameObject logos;
    
    void Start () {
        // //オブジェクトの座標
        // float x = Random.Range(-10.0f, 10.0f);
        // float y = Random.Range(-10.0f, 10.0f);
        
        // //オブジェクトを生産
        // Instantiate(logos, new Vector2(x, y), Quaternion.identity);
    }
	
	// Update is called once per frame
	void Update () {
        //オブジェクトの座標
        int isMake = Random.Range(1,100);
        if ( isMake >= 90 ) {
            float x = Random.Range(-50.0f, 50.0f);
            float y = Random.Range(-50.0f, 50.0f);
            //オブジェクトを生産
            Instantiate(logos, new Vector2(x, y), Quaternion.identity);
        }
        // Destroy(this, 5.0f);
	}

}
