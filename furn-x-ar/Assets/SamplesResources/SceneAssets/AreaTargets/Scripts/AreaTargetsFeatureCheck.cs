/*===============================================================================
Copyright (c) 2022 PTC Inc. All Rights Reserved.
 
Vuforia is a trademark of PTC Inc., registered in the United States and other
countries.
===============================================================================*/

using System;
using UnityEngine;
using Vuforia;

public class AreaTargetsFeatureCheck : MonoBehaviour
{
    const string UNSUPPORTED_DEVICE_TITLE = "Unsupported Device";
    const string UNSUPPORTED_SETTINGS_TITLE = "Unsupported Settings";
    const string UNSUPPORTED_WEBCAM_TITLE = "Unsupported Webcam PlayMode";
    const string ERROR_DEVICE_TRACKER_PLATFORM = "AreaTargets require the device to support ARCore or ARKit.";
    const string ERROR_DEVICE_TRACKER_NOT_INITIALIZED = "AreaTargets require the Device Tracker to be enabled, please make sure " +
                                                        "\"Track Device Pose\" is checked in the Vuforia Configuration.";
    const string ERROR_WEBCAM_PLAYMODE = "AreaTargets are not supported in WebCam PlayMode.";

    public NavigationHandler NavigationHandler;
    
    void Start()
    {
        VuforiaApplication.Instance.OnVuforiaStarted += OnVuforiaStarted;
    }

    void OnVuforiaStarted()
    {
        if (VuforiaRuntimeUtilities.IsSimulatorPlayMode())
            return;

        if (VuforiaRuntimeUtilities.IsWebCamPlayMode())
            MessageBox.DisplayMessageBox(UNSUPPORTED_WEBCAM_TITLE, ERROR_WEBCAM_PLAYMODE, true, GoBackToMainMenu);
        else if (VuforiaRuntimeUtilities.GetActiveFusionProvider() != FusionProviderType.PLATFORM_SENSOR_FUSION)
            MessageBox.DisplayMessageBox(UNSUPPORTED_DEVICE_TITLE, ERROR_DEVICE_TRACKER_PLATFORM, true, GoBackToMainMenu);
        else if (!VuforiaConfiguration.Instance.DeviceTracker.AutoInitAndStartTracker)
            MessageBox.DisplayMessageBox(UNSUPPORTED_SETTINGS_TITLE, ERROR_DEVICE_TRACKER_NOT_INITIALIZED, true, GoBackToMainMenu);
    }
    
    void GoBackToMainMenu()
    {
        NavigationHandler.HandleBackButtonPressed();
    }
}
