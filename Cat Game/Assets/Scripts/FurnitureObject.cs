using UnityEngine;
using System.Collections;

public class FurnitureObject : MonoBehaviour {

    public bool can_hide;
    public int hideable_cats = 3;
    int cats_hidden = 0;
    public float[] cats;
    Animator anim;
    GameObject SFX;
    // Use this for initialization
    void Start() {
        cats = new float[hideable_cats];
        SFX = GameObject.FindWithTag("SFX");
        SFX.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update() {
        for (int i = 0; i < hideable_cats; i++)
        {
            cats[i] -= Time.deltaTime;
            if (cats_hidden > i & cats[i] <= 3.0F)
            {
                Animation anim = SFX.GetComponent<Animation>();
                SFX.gameObject.SetActive(true);
                anim.Play("Knock_Animation");
                if (cats_hidden > i & cats[i] <= 0.0F)
                {
                    SFX.gameObject.SetActive(false);
                    anim.Stop();
                    removeCat(i);
                    continue; }
            }
        }
    }


    public bool addCat(float catTime){
        if(!can_hide) {
            Debug.Log("cant hide the cat.");
            return false; }
        if (cats_hidden < hideable_cats)
        {
            Debug.Log(cats_hidden);
            cats[cats_hidden++] = catTime;
            return true;
        } else { return false; }
        return true;
    }
    void removeCat(int index) { cats[index] = 0; cats_hidden--; }
}
