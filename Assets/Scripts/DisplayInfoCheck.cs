using UnityEngine;
using TMPro;

public class DisplayInfoCheck : MonoBehaviour {

    public TMP_Text resolution;
    public TMP_Text dpi;

    void Start() {
        resolution.text = $"Resolution: {Screen.width} x {Screen.height}";
        dpi.text = "DPI: " + Screen.dpi.ToString();
    }
}
