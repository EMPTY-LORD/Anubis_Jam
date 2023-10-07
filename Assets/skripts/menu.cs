using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void BaskaSahneyeGit(string sahneAdi)
    {
        SceneManager.LoadScene(sahneAdi);
    }
      // Oyundan çıkış yapmak için bu fonksiyonu kullanabilirsiniz
    public void OyundanCik()
    {
        // Uygulamayı kapat
        Application.Quit();
    }
}
