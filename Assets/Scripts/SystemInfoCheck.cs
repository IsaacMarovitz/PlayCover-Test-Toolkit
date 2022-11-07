using UnityEngine;
using TMPro;

public class SystemInfoCheck : MonoBehaviour {

    public TMP_Text deviceModel;
    public TMP_Text deviceName;
    public TMP_Text deviceType;
    public TMP_Text deviceUniqueIdentifier;
    public TMP_Text graphicsDeviceName;
    public TMP_Text graphicsDeviceID;
    public TMP_Text graphicsDeviceType;
    public TMP_Text graphicsDeviceVendor;
    public TMP_Text graphicsDeviceVendorID;
    public TMP_Text graphicsDeviceVersion;
    public TMP_Text graphicsMemorySize;
    public TMP_Text graphicsShaderLevel;
    public TMP_Text operatingSystem;
    public TMP_Text operatingSystemFamily;
    public TMP_Text processorCount;
    public TMP_Text supportsHDR;

    void Start() {
        Application.targetFrameRate = 120;
        deviceModel.text = "Device model: " + SystemInfo.deviceModel;
        deviceName.text = "Device name: " + SystemInfo.deviceName;
        deviceType.text = "Device type: " + SystemInfo.deviceType.ToString();
        deviceUniqueIdentifier.text = "Device unique identifier: " + SystemInfo.deviceUniqueIdentifier;
        graphicsDeviceName.text = "Graphics device name: " + SystemInfo.graphicsDeviceName;
        graphicsDeviceID.text = "Graphics device id: " + SystemInfo.graphicsDeviceID.ToString();
        graphicsDeviceType.text = "Graphics device type: " + SystemInfo.graphicsDeviceType.ToString();
        graphicsDeviceVendor.text = "Graphics device vendor: " + SystemInfo.graphicsDeviceVendor;
        graphicsDeviceVendorID.text = "Graphics device vendor id: " + SystemInfo.graphicsDeviceVendorID.ToString();
        graphicsDeviceVersion.text = "Graphics device version: " + SystemInfo.graphicsDeviceVersion;
        graphicsMemorySize.text = "Graphics memory size: " + SystemInfo.graphicsMemorySize.ToString();
        graphicsShaderLevel.text = "Graphics shader level: " + SystemInfo.graphicsShaderLevel.ToString();
        operatingSystem.text = "Operating system: " + SystemInfo.operatingSystem;
        operatingSystemFamily.text = "Operating system family: " + SystemInfo.operatingSystemFamily.ToString();
        processorCount.text = "Processor count: " + SystemInfo.processorCount.ToString();
        supportsHDR.text = "Supports HDR: " + (SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.DefaultHDR) ? "True" : "False");
    }
}
