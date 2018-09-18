using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UImarg : MonoBehaviour {
    private static UImarg inst;
    public static UImarg Inst {
        get {
            if (inst==null) {
                inst = new UImarg();
            }
              return inst;
        }

    }

	void Awake () {
    
      
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
