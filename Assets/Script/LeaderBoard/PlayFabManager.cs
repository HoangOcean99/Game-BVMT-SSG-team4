using PlayFab;
using PlayFab.ClientModels;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class PlayFabManager : MonoBehaviour
{
    private InstanceVariables instanceGeneral;
    public Text CurrentRank;
    public Text CurrentName;
    public Text CurrentScore;
    public GameObject entryPrefab; // Prefab dòng leaderboard
    public Transform content; // Content của Scroll View
    //public Text currentPlayerText; // Hiển thị thứ hạng của người chơi hiện tại

    private string playerName; // Tên người chơi (có thể nhập từ UI)
    private int playerScore; // Điểm của người chơi


    void Start()
    {
        instanceGeneral = FindAnyObjectByType<InstanceVariables>();
        playerName = instanceGeneral.name;
        playerScore = instanceGeneral.point;
        // Đặt Title ID của bạn
        PlayFabSettings.staticSettings.TitleId = "135FDD";

        // Đăng nhập vào PlayFab
        LoginToPlayFab();
    }

    void LoginToPlayFab()
    {
        var request = new LoginWithCustomIDRequest
        {
            CustomId = playerName,
            CreateAccount = true
        };
        PlayFabClientAPI.LoginWithCustomID(request, OnLoginSuccess, OnLoginFailure);
    }

    void OnLoginSuccess(LoginResult result)
    {
        Debug.Log("Đăng nhập thành công!");

        // Cập nhật tên người chơi
        UpdatePlayerName(playerName);

        // Lưu điểm số của người chơi
        SubmitScore(playerScore);

        // Lấy leaderboard để hiển thị
        GetLeaderboard();
    }

    void OnLoginFailure(PlayFabError error)
    {
        Debug.LogError("Lỗi đăng nhập: " + error.GenerateErrorReport());
    }

    void UpdatePlayerName(string name)
    {
        var request = new UpdateUserTitleDisplayNameRequest
        {
            DisplayName = name
        };

        PlayFabClientAPI.UpdateUserTitleDisplayName(request,
            result => Debug.Log("Tên người chơi cập nhật: " + result.DisplayName),
            error => Debug.LogError("Lỗi cập nhật tên: " + error.GenerateErrorReport()));
    }

    public void SubmitScore(int score)
    {
        if (PlayFabClientAPI.IsClientLoggedIn())
        {
            var request = new UpdatePlayerStatisticsRequest
            {
                Statistics = new List<StatisticUpdate>
                {
                    new StatisticUpdate { StatisticName = "HighScore", Value = score }
                }
            };

            PlayFabClientAPI.UpdatePlayerStatistics(request,
                result => Debug.Log("Cập nhật điểm thành công!"),
                error => Debug.LogError("Lỗi cập nhật điểm: " + error.GenerateErrorReport()));
        }
        else
        {
            Debug.LogError("Chưa đăng nhập, không thể gửi điểm.");
        }
    }

    public void GetLeaderboard()
    {
        var request = new GetLeaderboardRequest
        {
            StatisticName = "HighScore",
            StartPosition = 0,
            MaxResultsCount = 10
        };

        PlayFabClientAPI.GetLeaderboard(request, result =>
        {
            foreach (Transform child in content) Destroy(child.gameObject); // Xóa danh sách cũ

            foreach (var item in result.Leaderboard)
            {
                GameObject entry = Instantiate(entryPrefab, content);
                entry.transform.Find("RankText").GetComponent<Text>().text = (item.Position + 1).ToString();
                entry.transform.Find("NameText").GetComponent<Text>().text = item.DisplayName ?? "Unknown";
                entry.transform.Find("ScoreText").GetComponent<Text>().text = item.StatValue.ToString();
            }

            GetPlayerRank();
        }, error =>
        {
            Debug.LogError("Lỗi lấy leaderboard: " + error.GenerateErrorReport());
        });
    }

    void GetPlayerRank()
    {
        var request = new GetLeaderboardAroundPlayerRequest
        {
            StatisticName = "HighScore",
            MaxResultsCount = 1
        };

        PlayFabClientAPI.GetLeaderboardAroundPlayer(request, result =>
        {
            if (result.Leaderboard.Count > 0)
            {
                var player = result.Leaderboard[0];
                //currentPlayerText.text = $"Bạn đang xếp hạng {player.Position + 1} với {player.StatValue} điểm!";
                CurrentRank.text = (player.Position +1)+ "";
                CurrentName.text = player.DisplayName ?? "Unknown";
                CurrentScore.text = player.StatValue + "";
            }
        }, error =>
        {
            Debug.LogError("Lỗi lấy hạng người chơi: " + error.GenerateErrorReport());
        });
    }
}
