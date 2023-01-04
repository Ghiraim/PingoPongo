using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif
public class StartMenu : MonoBehaviour
{
    public static string name1;
    private Button button;
    public InputField UsernameInput;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(ChangeScene);
    }
    public void ReadStringInput(string s){
        name1 = s;
        Debug.Log(name1);
    }
    // Update is called once per frame
    void Update()
    {
       
    }
    public void ChangeScene(){
        
        SceneManager.LoadScene(0);
        
    }
    /*public void StartNew(){
        SceneManager.LoadScene(0);
        
    }*/
    public void Exit(){
        MainManager.Instance.SaveScore();
    #if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
    #else
        Application.Quit();
    #endif
    }
}
