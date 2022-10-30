using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Kittipop_Chaimasphong
{
    public class GameAppFlowManager : MonoBehaviour
    {
        protected static bool IsSceneOptionLoaded;

        public void loadScene(string sceneName)
        {
            SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
        }

        public void UnloadScene(string sceneName)
        {
            SceneManager.UnloadSceneAsync(sceneName);
        }

        public void loadSceneAdditive(string sceneName)
        {
            SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
        }

        public void loadOptionScene(string optionScenename)
        {
            if (!IsSceneOptionLoaded)
            {
                SceneManager.LoadScene(optionScenename, LoadSceneMode.Additive);
                IsSceneOptionLoaded = true;
            }
        }

        public void UnloadOptionScene(string optionSceneName)
        {
            if (IsSceneOptionLoaded)
            {
                SceneManager.UnloadSceneAsync(optionSceneName);
                IsSceneOptionLoaded = false;
            }
        }

        public void ExitGame()
        {
            Application.Quit();
        }

        #region scene load and unload event handler
        private void OnEnable()
        {
            SceneManager.sceneUnloaded -= sceneUnloadEventHandler;
            SceneManager.sceneLoaded -= sceneLoadedEventHandler;
        }

        private void sceneUnloadEventHandler(Scene scene)
        {

        }

        private void sceneLoadedEventHandler(Scene scene, LoadSceneMode mode)
        {
            if (scene.name.CompareTo("SceneOption") != 0)
            {
                IsSceneOptionLoaded = false;
            }
        }
        #endregion
    }
}