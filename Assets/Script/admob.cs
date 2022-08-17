using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
public class admob : MonoBehaviour
{
    private string adUnitId;
    private BannerView banner;
    // Use this for initialization
    void Start()
    {
        MobileAds.Initialize(initStatus => { });
        RequestBanner();
    }
    private void RequestBanner()
    {
#if UNITY_ANDROID
        adUnitId = "ca-app-pub-3940256099942544/6300978111"; Å@//test
        
#elif UNITY_IOS
        adUnitId = "ca-app-pub-3940256099942544/2934735716";   //test
#endif
        
        banner = new BannerView(adUnitId, AdSize.SmartBanner, AdPosition.Bottom);
        AdRequest request = new AdRequest.Builder().Build();
        banner.LoadAd(request);
        banner.Show();
    }
}