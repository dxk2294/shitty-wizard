﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickGroup : MonoBehaviour {

    public GameObject chickPrefab;
    public int chickBaseCount;
    public int chickCountVariance;

    private void Start() {

        GameObject player = GameObject.FindGameObjectWithTag("Player");
        
        int numChicks = chickBaseCount + Random.Range(0, chickCountVariance);
        for (int i = 0; i < numChicks; i++) {
            GameObject chick = Instantiate(chickPrefab, this.transform.position, Quaternion.identity);
            EnemyController ec = chick.GetComponent<EnemyController>();
            ec.target = player.transform;
        }

    }

}
