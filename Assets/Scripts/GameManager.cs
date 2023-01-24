using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private void Awake()
    {
        instance = this;
        SceneManager.sceneLoaded += LoadState;
    }
    
    // Resources

    public List<Sprite> playerSprites;
    public List<Sprite> weaponSprites;
    public List<int> weaponPrices;
    public List<int> xpTable;

    // References
    public Player player;
    // public weapon weapon...

    // Logic
    public int pesos;
    public int experience;

    // Save State
    public void SaveState()
    {
        Debug.Log("SaveState");
    }
    public void LoadState(Scene s, LoadSceneMode mode)
    {
        SceneManager.sceneLoaded -= LoadState;
        Debug.Log("LoadState");
    }
}