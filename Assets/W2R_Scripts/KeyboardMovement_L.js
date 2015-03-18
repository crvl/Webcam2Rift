#pragma strict

var speed : float = 0.005;
var zoomSpeed : float = 0.02;
var originalPos : Vector3;
var calibratedPos : Vector3;
var useCalibratedSettings : boolean = true;

originalPos = this.transform.localPosition;
// Calibrated and Optimized Positions
calibratedPos = Vector3(0.5, -0.7, 8);

// (if not ideal, reset via 0-Key or comment out!)
if (useCalibratedSettings == true) {
	this.transform.localPosition = calibratedPos;
}


function LateUpdate () {

//	Zoom
	if (Input.GetKey("q")) {
		this.transform.localPosition.z += this.zoomSpeed;
	}
	
	if (Input.GetKey("e")) {
		this.transform.localPosition.z -= this.zoomSpeed;
	}
		
//	Vertical Alignment	
	if (Input.GetKey("w")) {
		this.transform.localPosition.y += this.speed;
	}
	
	if (Input.GetKey("s")) {
		this.transform.localPosition.y -= this.speed;
	}
	
//	Horizontal Alignment			
	if (Input.GetKey("a")) {
		this.transform.localPosition.x += this.speed;
	}
	
	if (Input.GetKey("d")) {
		this.transform.localPosition.x -= this.speed;
	}
		
//	Reset / Log	
	if (Input.GetKey("0")) {
		this.transform.localPosition = this.originalPos;
	}
	
	if (Input.GetKey("l")) {
		Debug.Log(this.transform.localPosition + " L ");
	}
}