using System.IO;
using System;
using UnityEngine;
using System.Threading.Tasks;

public class ScreenshotManager : MonoBehaviour
{
    // Kullanilacak tusu belirle (ornegin "S" tusu icin KeyCode.S)
    public KeyCode screenshotKey = KeyCode.S;

    // Ekran goruntulerinin kaydedilecegi klasor
    public string screenshotFolder = "Screenshots";

    public GameObject canvas;
    void Update()
    {
        // Tusa basildiginda screenshot al
        if (Input.GetKeyDown(screenshotKey))
        {
            CaptureScreenshot();
        }
    }

    async void CaptureScreenshot()
    {
        // UI objeleri ss'de gozukmemesi icin kapatildi
        canvas.SetActive(false);
        // UI in sahneden kalkmasi icin 1 ms delay olusturuldu
        await Task.Delay(1);

        // Klasor olustur (eger yoksa)
        if (!Directory.Exists(screenshotFolder))
        {
            Directory.CreateDirectory(screenshotFolder);
        }

        // Dosya adi
        string timestamp = System.DateTime.Now.ToString("yyyyMMdd_HHmmss");
        string fileName = $"SS_{timestamp}.png";

        // Ekran goruntusunu al ve dosyaya kaydet
        string filePath = Path.Combine(screenshotFolder, fileName);
        ScreenCapture.CaptureScreenshot(filePath);
        await Task.Delay(1);
        canvas.SetActive(true);

        // Konsola bilgi yazdir
        Debug.Log($"Screenshot captured: {filePath}");

    }
}
