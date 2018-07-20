using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : ItemBase {

    public ShotType ShotT = ShotType.Multi;
    public float ShotInterval = 0.15f;

    public AudioClip ShotAudio;
    public AudioSource MuzzleSource;

    private bool ShotIn = false;
    private float NextShot = 0;
    private bool NeedRelease = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void UpdateWeapon () {

        bool fb = Input.GetButton("Fire1");

        if (NeedRelease)
        {
            if (fb == false)
            {
                NeedRelease = false;
            }
        }

        if (fb && NeedRelease == false)
        {
            if (ShotIn==false)
            {
                ShotIn = true;
                DoShot();
                if(ShotT == ShotType.Single)
                {
                    ShotIn = false;
                    NeedRelease = true;
                }
                NextShot = Time.timeSinceLevelLoad + ShotInterval;
            }
            else
            {
                if (Time.timeSinceLevelLoad > NextShot)
                {
                    DoShot();
                    NextShot = Time.timeSinceLevelLoad + ShotInterval;
                }
            }
        }


	}

    void DoShot()
    {
        MuzzleSource.clip = ShotAudio;
        MuzzleSource.Play();
        Debug.Log("Shot!");
    }

}

public enum ShotType
{
    Single,Multi
}
