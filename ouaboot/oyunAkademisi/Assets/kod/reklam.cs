using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using System;


public class reklam : MonoBehaviour
{
    private RewardedAd rewardedAd;
    joy joy2;
    public GameObject joy3;

    void Start()
    {
        joy2 = joy3.GetComponent<joy>();

        string adUnitId;
        adUnitId = "ca-app-pub-3940256099942544/5354046379";

        MobileAds.Initialize(initStatus => { });

        rewardedAd = new RewardedAd(adUnitId);

        // Called when an ad request has successfully loaded.
        this.rewardedAd.OnAdLoaded += HandleRewardedAdLoaded;
        // Called when an ad request failed to load.
        //this.rewardedAd.OnAdFailedToLoad += HandleRewardedAdFailedToLoad;
        // Called when an ad is shown.
        this.rewardedAd.OnAdOpening += HandleRewardedAdOpening;
        // Called when an ad request failed to show.
        this.rewardedAd.OnAdFailedToShow += HandleRewardedAdFailedToShow;
        // Called when the user should be rewarded for interacting with the ad.
        this.rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;
        // Called when the ad is closed.
        this.rewardedAd.OnAdClosed += HandleRewardedAdClosed;
        UserChoseToWatchAd();

        AdRequest request = new AdRequest.Builder().Build();
        rewardedAd.LoadAd(request);
    }

    public void HandleRewardedAdLoaded(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardedAdLoaded event received");
    }

   
    public void HandleRewardedAdOpening(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardedAdOpening event received");
    }

    public void HandleRewardedAdFailedToShow(object sender, AdErrorEventArgs args)
    {
        MonoBehaviour.print(
            "HandleRewardedAdFailedToShow event received with message: "
                             + args.Message);
    }

    public void HandleRewardedAdClosed(object sender, EventArgs args)
    {
        string adUnitId;
        adUnitId = "ca-app-pub-3940256099942544/5354046379";

        rewardedAd = new RewardedAd(adUnitId);

        AdRequest request = new AdRequest.Builder().Build();
        rewardedAd.LoadAd(request);

    }
    public void HandleUserEarnedReward(object sender, Reward args)
    {
        joy2.kosb += 250;
    }
    public void UserChoseToWatchAd()
    {
        if (this.rewardedAd.IsLoaded())
        {
            this.rewardedAd.Show();
            this.rewardedAd.OnAdClosed += HandleRewardedAdClosed;
            this.rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;
        }
    }
}
