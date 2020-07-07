using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class loading : MonoBehaviour
{
    private CanvasGroup loadingPanel;
    private Image load;

    private void Awake()
    {
        loadingPanel = GameObject.Find("載入畫面").GetComponent<CanvasGroup>();
        load = GameObject.Find("進度條").GetComponent<Image>();      
    }
    private IEnumerator Loading()
    {
        loadingPanel.alpha = 1;                      // 顯示
        loadingPanel.blocksRaycasts = true;          // 啟動遮擋

        yield return new WaitForSeconds(0.5f);
        loadingPanel.alpha = 0;                      // 隱藏
        loadingPanel.blocksRaycasts = false;
    }
}
