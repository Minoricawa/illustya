﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clear : MonoBehaviour {

	public void PushClear()
    {
        SceneManager.LoadScene("TitleScene");
    }

}
