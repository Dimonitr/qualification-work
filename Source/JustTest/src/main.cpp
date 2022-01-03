#include <Arduino.h>

void setup() {
   Serial.begin(9600);
   pinMode(8, OUTPUT);
   pinMode(9, OUTPUT);
   pinMode(10, OUTPUT);
   pinMode(11, OUTPUT);
   pinMode(A0, INPUT);
   pinMode(3, INPUT);
   pinMode(5, INPUT);
}

int back, b, l, t, r;

bool pause = false;

void loop() {
	if(digitalRead(3) == HIGH){
		pause = !pause;
		while(digitalRead(3) == HIGH);
	}
	if(digitalRead(6) == HIGH){
		Serial.println("d");
		while(digitalRead(6) == HIGH);
	}
	if(!pause){
	
	back = analogRead(A0);
    digitalWrite(8, 1);
	delay(50);
 	b = analogRead(A0);
	digitalWrite(8, 0);
	
	
    digitalWrite(9, 1);
	delay(50);
	l = analogRead(A0);
	digitalWrite(9, 0);
	
	
    digitalWrite(10, 1);
	delay(50);
	t = analogRead(A0);
	digitalWrite(10, 0);
	
	
    digitalWrite(11, 1);
	delay(50);
	r = analogRead(A0);
	digitalWrite(11, 0);
	
    int db = b- back;
	int dl = l- back;
	int dt = t- back;
	int dr = r- back;
	
	Serial.println("o");
	Serial.println(db);
	Serial.println(dl);
	Serial.println(dt);
	Serial.println(dr);
	Serial.println("c");
	}
	else{
		Serial.println("c");
	}
	}