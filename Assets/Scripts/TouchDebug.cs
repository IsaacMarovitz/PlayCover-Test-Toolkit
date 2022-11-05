using UnityEngine;
using System.Collections.Generic;

public class TouchDebug : MonoBehaviour {

    public GameObject touchPrefab;
    public List<GameObject> touchIndicators = new List<GameObject>();

    void Update() {
        for (int i = 0; i < touchIndicators.Count; i++) {
            // If an already instantiated indicator exists at that index, use it
            if (i < Input.touchCount) {
                Vector2 touchPos = Input.GetTouch(i).position;
                touchIndicators[i].transform.position = new Vector3(touchPos.x, touchPos.y, 0);
            } else {
                // If extra indicators exist, destroy them
                GameObject obj = touchIndicators[i];
                touchIndicators.RemoveAt(i);
                GameObject.Destroy(obj);
            }
        }

        // If there aren't enough indicators
        if (touchIndicators.Count < Input.touchCount) {
            for (int i = touchIndicators.Count; i < Input.touchCount; i++) {
                Vector2 touchPos = Input.GetTouch(i).position;
                Transform transform = GameObject.Instantiate(touchPrefab, new Vector3(touchPos.x, touchPos.y, 0), Quaternion.identity).transform;
                transform.SetParent(this.transform);
                touchIndicators.Add(transform.gameObject);
            }
        }
    }
}
