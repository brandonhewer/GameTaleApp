using UnityEngine;
using System.Collections;

public class LoadGame : MonoBehaviour {

	public int height;
	public int width;
	public GameObject floor;

	// Use this for initialization
	void Start () {
		drawStairs();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	/**
	 * Draws the stairs. 
	 */
	void drawStairs() {

		// Iterate through all stair levels
		// to draw.
		for(int i=0; i<height; i++) {
			drawStairLevel (i);
		}
	}

	/**
	 * Draws a stair level.
	 * 
	 * level:	The height of the stair level.
	 */
	void drawStairLevel(int height) {

		// Iterate through all stair components
		// on the current level to draw.
		for(int i=0; i<width; i++) {
			createStairComponent (height, i);
		}
	}

	void createStairComponent(int height, int width) {
		Vector3 pos = new Vector3(width, height, height);
		GameObject component = (GameObject) Instantiate(floor, pos, Quaternion.identity);
	}
}
