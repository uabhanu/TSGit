using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BhanuPrefsManager : MonoBehaviour
{
    const string MASTER_VOLUME_KEY = "MasterVolume";
    const string DIFFICULTY_KEY = "Difficulty";
    const string LEVEL_KEY = "LevelUnlocked";

    /// <summary>
    /// Removes all keys and values from Bhanu's Preferences so use with caution.
    /// </summary>
    public static void DeleteAll()
    {
        PlayerPrefs.DeleteAll();
    }

    public static float GetDifficulty()
    {
        return PlayerPrefs.GetFloat(DIFFICULTY_KEY);
    }

    public static float GetMasterVolume()
    {
        return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
    }

    public static bool IsLevelUnlocked(int level)
    {
        int levelValue = PlayerPrefs.GetInt(LEVEL_KEY + level.ToString());
        bool isUnlocked = (levelValue == 1);

        if(level <= SceneManager.sceneCountInBuildSettings - 1)
        {
                return isUnlocked;
        }
        else
        {
            Debug.LogError("Sir Bhanu, You are trying to unlock level that doesn't exist");
            return false;
        }
    }

    public static void SetDifficulty(float difficulty)
    {
        if(difficulty >= 0 && difficulty <= 3)
        {
            PlayerPrefs.SetFloat(DIFFICULTY_KEY , difficulty);
        }
        else
        {
            Debug.LogError("Sir Bhanu, Difficulty is out of range");
        }
    }

    public static void SetMasterVolume(float volume)
    {
        if(volume >= 0f && volume <= 1f)
        {
            PlayerPrefs.SetFloat(MASTER_VOLUME_KEY , volume);
        }
        else
        {
            Debug.LogError("Sir Bhanu, Master Volume out of Range");
        }
    }

    public static void UnlockLevel(int level)
    {
        if(level <= SceneManager.sceneCountInBuildSettings - 1)
        {
            PlayerPrefs.SetInt(LEVEL_KEY + level.ToString() , 1); // 1 represents true of Boolean as Playerprefs don't have Bool
        }
        else
        {
            Debug.LogError("Sir Bhanu, You are trying to unlock level that doesn't exist");
        }
    }
}