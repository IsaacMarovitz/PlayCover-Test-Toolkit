using UnityEngine;

public class TouchDebug : MonoBehaviour {

    public GameObject touchPrefab;

    void Update() {
        foreach (Transform child in transform) {
            GameObject.Destroy(child.gameObject);
        }

        for (int i = 0; i < Input.touchCount; i++) {
            Vector2 touchPos = Input.GetTouch(i).position;
            Transform transform = GameObject.Instantiate(touchPrefab, new Vector3(touchPos.x, touchPos.y, 0), Quaternion.identity).transform;
            transform.SetParent(this.transform);
        }
    }
}
