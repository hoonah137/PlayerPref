using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveManager : MonoBehaviour
{
    //Variables
    
    [SerializeField] Text _userNameText;
    [SerializeField] Text _userScoreText;
    [SerializeField] Text _userPositionText;

    [SerializeField] string _userName;
    [SerializeField] int _userScore;
    [SerializeField] Vector3 _userPosition;



    // Start is called before the first frame update
    void Start()
    {
        LoadData();
        
    }

    public void SaveData()
    {
        PlayerPrefs.SetString("Name", _userName);
        PlayerPrefs.SetInt("Score", _userScore);
        PlayerPrefs.SetFloat("positionX", _userPosition.x);
        PlayerPrefs.SetFloat("positionY", _userPosition.y);
        PlayerPrefs.SetFloat("positionZ", _userPosition.z);
        
        LoadData();
    }

    void LoadData ()
    {
        _userNameText.text = "User Name: " + PlayerPrefs.GetString("Name","no name");
        _userScoreText.text = "Player Score: " + PlayerPrefs.GetInt("Score", 000).ToString();
        _userPositionText.text = "Player position: " + PlayerPrefs.GetFloat("positionX", 0).ToString() + "x " +
                                 PlayerPrefs.GetFloat("positionY", 0).ToString() + "y " +
                                 PlayerPrefs.GetFloat("positionZ", 0).ToString() + "z";
    }

    public void DeleteData()
    {
        PlayerPrefs.DeleteKey("Name");
        PlayerPrefs.DeleteKey("Score");
        PlayerPrefs.DeleteKey("PositionX");
        PlayerPrefs.DeleteKey("positionY");
        PlayerPrefs.DeleteKey("positionZ");

        LoadData();
    }
}
