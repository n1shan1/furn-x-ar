/*===============================================================================
Copyright (c) 2022 PTC Inc. All Rights Reserved.

Vuforia is a trademark of PTC Inc., registered in the United States and other
countries.
===============================================================================*/

using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class BarcodeMenu : MonoBehaviour
{
    public BarcodeScanner BarcodeScanner;
    public Toggle Toggle1DTypes;
    public Toggle Toggle2DTypes;
    public Toggle ToggleAllTypes;
    public CanvasGroup BarcodeTypeMenu;

    /// <summary>
    /// Called when the script is started
    /// </summary>
    void Awake()
    {
        VuforiaApplication.Instance.OnVuforiaStarted += OnVuforiaStarted;
    }

    /// <summary>
    /// Called when the script is destroyed
    /// </summary>
    void OnDestroy()
    {
        VuforiaApplication.Instance.OnVuforiaStarted -= OnVuforiaStarted;
    }

    /// <summary>
    /// Called when Vuforia is started
    /// </summary>
    void OnVuforiaStarted()
    {
        ToggleBarcodeMode2D();
    }

    /// <summary>
    /// Show/Hide the Barcode Mode menu
    /// </summary>
    public void ShowBarcodeModeMenu(bool show)
    {
        BarcodeTypeMenu.alpha = show ? 1.0f : 0.0f;
        BarcodeTypeMenu.interactable = show;
        BarcodeTypeMenu.blocksRaycasts = show;
    }

    /// <summary>
    /// Toggle the 1D barcode mode
    /// </summary>
    public void ToggleBarcodeMode1D()
    {
        Toggle1DTypes.SetIsOnWithoutNotify(true);
        Toggle2DTypes.SetIsOnWithoutNotify(false);
        ToggleAllTypes.SetIsOnWithoutNotify(false);
        BarcodeScanner.SetBarcodeScannerMode(BarcodeScanner.Mode.SCAN_1D);
    }

    /// <summary>
    /// Toggle the 2D barcode mode
    /// </summary>
    public void ToggleBarcodeMode2D()
    {
        Toggle1DTypes.SetIsOnWithoutNotify(false);
        Toggle2DTypes.SetIsOnWithoutNotify(true);
        ToggleAllTypes.SetIsOnWithoutNotify(false);
        BarcodeScanner.SetBarcodeScannerMode(BarcodeScanner.Mode.SCAN_2D);
    }
    
    /// <summary>
    /// Toggle the ALL barcode mode
    /// </summary>
    public void ToggleBarcodeModeAll()
    {
        Toggle1DTypes.SetIsOnWithoutNotify(false);
        Toggle2DTypes.SetIsOnWithoutNotify(false);
        ToggleAllTypes.SetIsOnWithoutNotify(true);
        BarcodeScanner.SetBarcodeScannerMode(BarcodeScanner.Mode.ALL);
    }
    
    /// <summary>
    /// Toggle if sound should be played
    /// </summary>
    public void ToggleSounds()
    {
        Debug.Log("ToggleSounds");
        BarcodeScanner.PlaySounds = !BarcodeScanner.PlaySounds;
    }
}
