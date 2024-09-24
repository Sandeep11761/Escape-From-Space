using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class AnimationControlScript : MonoBehaviour
{
    public Animator anim;
    public float x;
    public float y;
    float z = 2.3f;
    float speed = 2.0f;
    public Button optionsButton;
    public Animator OptionsAnim;
    public AudioSource buttonSound;
    public Animator quitButton;
    public Animator backbutton;
    public GameObject mainMenu, optionMenu;


    public GameObject muteAudio;
    public Image muteIcon;
    public GameObject playeAudio;
    [SerializeField] RectTransform fader;
    public Animator loadingBar;
    public GameObject loadingScene;
    public Slider audioControl;
    public AudioSource intro;

    
    // Start is called before the first frame update
    void Start()
    {
       
       
        /*fader.gameObject.SetActive(true);
        LeanTween.scale(fader, new Vector3(1, 1, 1), 0);
        LeanTween.scale(fader, Vector3.zero, 0.5f).setOnComplete(() =>
        {
            fader.gameObject.SetActive(false);
        });*/
    }

    // Update is called once per frame
    public void LeanTweenEffect()
    {
        fader.gameObject.SetActive(true);
        LeanTween.scale(fader, Vector3.zero, 0);
        LeanTween.scale(fader, new Vector3(1, 1, 1), 0.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete(() =>
        {
            fader.gameObject.SetActive(false);
        });
    }
    public void PlayButton()
    {
      
       
        buttonSound.Play();
        Debug.Log("playing");
        anim.SetBool("Play", true);
        Invoke("LeanTweenEffect", y);
        Invoke("sceneActivate", x);
        Invoke("LoadingBarScene", z);

    }
    public void sceneActivate()
    {
        anim.SetBool("Scene", true);
        SceneManager.LoadScene(1);
        
    }
    public void OptionsAnimations()
    {
        Invoke("DeactivateMainMenu", speed);
        Invoke("ActivateOptionMenu",speed);
        buttonSound.Play();
        OptionsAnim.SetBool("Options", true);
    }

    public void QuitButton()
    {
        buttonSound.Play();
        quitButton.SetBool("Quit", true);
        Debug.Log("Application end");
        Application.Quit();
    }
    public void BackButton()
    {
        buttonSound.Play();
        Invoke("ActivateMaineMenu", speed);
        Invoke("DeactivateOptionMenu", speed);
        backbutton.SetBool("Back", true);


    }
    public void ActivateMaineMenu()
    {
        mainMenu.SetActive(true);
    }
    public void DeactivateMainMenu()
    {
        mainMenu.SetActive(false);
    }
    public void DeactivateOptionMenu()
    {
        optionMenu.SetActive(false);
    }
    public void ActivateOptionMenu()
    {
        optionMenu.SetActive(true);
    }
    public void MuteAuido()
    {
        buttonSound.Play();
        muteAudio.SetActive(false);
        playeAudio.SetActive(true);
        
    }
    public void PlayAudio()
    {
        buttonSound.Play();
        muteAudio.SetActive(false);
        playeAudio.SetActive(true);
        
       
    }
    public void LoadingBarScene()
    {
        Debug.Log("working");
        loadingScene.SetActive(true);
        loadingBar.SetBool("Loading", true);
    }
   /* public void ControlAudio()
    {
        intro.volume = audioControl.value;
*/
    
}