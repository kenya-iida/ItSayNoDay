using UnityEngine.SceneManagement;

public static class MySceneManager
{
    public static void LoadHomeScene()
    {
        SceneManager.LoadScene("Home");
    }

    public static void LoadCreateRoomScene()
    {
        SceneManager.LoadScene("CreateRoom");
    }

    public static void LoadRulesScene()
    {
        SceneManager.LoadScene("Rules");
    }
}
