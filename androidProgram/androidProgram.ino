
#include <TaskScheduler.h>
#include "Servo.h"

Servo servoPlatforma, servoZglob1, servoZglob2, servoZglob3, servoRot, servoHvataljka;
//Izmjeni TargetAngleove na stepene ako se koristi kod procentualne interpolacije!
int  TargetAnglePlatforma = 1500, TargetAngleZglob1 = 1500, TargetAngleZglob2 = 1500, TargetAngleZglob3 = 1500, TargetAngleRot = 1500, TargetAngleHvataljka = 1500;

//Need this for percentage interpolation
//float   CurrentAngle_Platforma = 1500, CurrentAngle_Zglob1 = 90 ;

//Need this for sigmoid interpolation for motor platforma
int delta_time_a = 1;
float result_a = 1500;
float  p_a = TargetAnglePlatforma;
float k_a = TargetAnglePlatforma;
float o_a = abs(p_a - k_a);
float d_a = o_a * 100000;
float b_a = 0.08;


//Need this for sigmoid interpolation for motor zglob1
int delta_time_b = 1;
float result_b = 1500;
float  p_b = TargetAngleZglob1;
float k_b = TargetAngleZglob1;
float o_b = abs(p_b - k_b);
float d_b = o_b * 100000;
float b_b = 0.08;

//Need this for sigmoid interpolation for motor zglob2
int delta_time_c = 1;
float result_c = 1500;
float  p_c = TargetAngleZglob2;
float k_c = TargetAngleZglob2;
float o_c = abs(p_c - k_c);
float d_c = o_c * 100000;
float b_c = 0.08;


//Need this for sigmoid interpolation for motor zglob3
int delta_time_d = 1;
float result_d = 1500;
float  p_d = TargetAngleZglob3;
float k_d = TargetAngleZglob3;
float o_d = abs(p_d - k_d);
float d_d = o_d * 100000;
float b_d = 0.08;

//Need this for sigmoid interpolation for motor Rot
int delta_time_e = 1;
float result_e = 1500;
float  p_e = TargetAngleRot;
float k_e = TargetAngleRot;
float o_e = abs(p_e - k_e);
float d_e = o_e * 100000;
float b_e = 0.08;


//Need this for sigmoid interpolation for motor Hvataljka
int delta_time_f = 1;
float result_f = 1500;
float  p_f = TargetAngleHvataljka;
float k_f = TargetAngleHvataljka;
float o_f = abs(p_f - k_f);
float d_f = o_f * 100000;
float b_f = 0.08;

//Get number preceding custom char, valid forms: "$Num$a/" or "$Num$b/" etc, also "$Num$a/$Num$b/$Num$c/...". When data contains multiple of angles, ORDER MATTERS!!!!
//Not valid: "$Num$b/$Num$a/", "a" MUST BE FIRST, "b" SECOND, "c" third etc.



/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



void Fx_Platforma() {

  //Kod procentualne interpolacije = Func:Log
  //Im using 11.11 as 1 degree = 11.11 microseconds. Starting point is 500micros so offset is 500
  //CurrentAngle_Platforma = (CurrentAngle_Platforma * 0.95)   + ((TargetAnglePlatforma *11.11+500) * 0.05 );
  //Serial.println(String(servoPlatforma.read()) + "," + String(CurrentAngle_Platforma) + "," + String(TargetAnglePlatforma));


  //Implementation of Sigmoid trajectory
  //Cap deltaTime
  if (delta_time_a > 300)
  {
    delta_time_a = 300;
  }

  if (result_a < TargetAnglePlatforma + 1 && result_a > TargetAnglePlatforma - 1 )
  {
    p_a = TargetAnglePlatforma;
  }

  k_a = TargetAnglePlatforma;
  o_a = abs(p_a - k_a);
  d_a = o_a * 500;

  //Formula of Sigmoid Func which I tweaked in Desmos graph, so I can manipulate end point, start point and stretch of func:
  //
  result_a = ( (k_a - p_a) * pow(2.71828, b_a * delta_time_a) ) / (pow(2.71828, b_a * delta_time_a) + d_a) + p_a;
  delta_time_a = delta_time_a + 5 ;

  servoPlatforma.writeMicroseconds(result_a);
}

void Fx_Zglob1()
{

  //Implementation of Sigmoid trajectory
  //Cap deltaTime
  if (delta_time_b > 300)
  {
    delta_time_b = 300;
  }

  if (result_b < TargetAngleZglob1 + 1 && result_b > TargetAngleZglob1 - 1 )
  {
    p_b = TargetAngleZglob1;
  }

  k_b = TargetAngleZglob1;
  o_b = abs(p_b - k_b);
  d_b = o_b * 500;

  //Formula of Sigmoid Func which I tweaked in Desmos graph, so I can manipulate end point, start point and stretch of func:
  //
  result_b = ( (k_b - p_b) * pow(2.71828, b_b * delta_time_b) ) / (pow(2.71828, b_b * delta_time_b) + d_b) + p_b;
  delta_time_b = delta_time_b + 5 ;

  servoZglob1.writeMicroseconds(result_b);

}

void Fx_Zglob2()
{
  //Implementation of Sigmoid trajectory
  //Cap deltaTime
  if (delta_time_c > 300)
  {
    delta_time_c = 300;
  }

  if (result_c < TargetAngleZglob2 + 1 && result_c > TargetAngleZglob2 - 1 )
  {
    p_c = TargetAngleZglob2;
  }

  k_c = TargetAngleZglob2;
  o_c = abs(p_c - k_c);
  d_c = o_c * 500;

  //Formula of Sigmoid Func which I tweaked in Desmos graph, so I can manipulate end point, start point and stretch of func:
  //
  result_c = ( (k_c - p_c) * pow(2.71828, b_c * delta_time_c) ) / (pow(2.71828, b_c * delta_time_c) + d_c) + p_c;
  delta_time_c = delta_time_c + 5 ;

  servoZglob2.writeMicroseconds(result_c);
  Serial.println(result_c);


}

void Fx_Zglob3()
{
  //Implementation of Sigmoid trajectory
  //Cap deltaTime
  if (delta_time_d > 300)
  {
    delta_time_d = 300;
  }

  if (result_d < TargetAngleZglob3 + 1 && result_d > TargetAngleZglob3 - 1 )
  {
    p_d = TargetAngleZglob3;
  }

  k_d = TargetAngleZglob3;
  o_d = abs(p_d - k_d);
  d_d = o_d * 500;

  //Formula of Sigmoid Func which I tweaked in Desmos graph, so I can manipulate end point, start point and stretch of func:
  //
  result_d = ( (k_d - p_d) * pow(2.71828, b_d * delta_time_d) ) / (pow(2.71828, b_d * delta_time_d) + d_d) + p_d;
  delta_time_d = delta_time_d + 5 ;

  servoZglob3.writeMicroseconds(result_d);
  Serial.println(result_d);

}

void Fx_Rot()
{
  //Implementation of Sigmoid trajectory
  //Cap deltaTime
  if (delta_time_e > 300)
  {
    delta_time_e = 300;
  }

  if (result_e < TargetAngleRot + 1 && result_e > TargetAngleRot - 1 )
  {
    p_e = TargetAngleRot;
  }

  k_e = TargetAngleRot;
  o_e = abs(p_e - k_e);
  d_e= o_e * 500;

  //Formula of Sigmoid Func which I tweaked in Desmos graph, so I can manipulate end point, start point and stretch of func:
  //
  result_e = ( (k_e - p_e) * pow(2.71828, b_e * delta_time_e) ) / (pow(2.71828, b_e * delta_time_e) + d_e) + p_e;
  delta_time_e = delta_time_e + 5 ;

  servoRot.writeMicroseconds(result_e);
  Serial.println(result_e);

}

void Fx_Hvataljka()
{
  //Implementation of Sigmoid trajectory
  //Cap deltaTime
  if (delta_time_f > 300)
  {
    delta_time_f = 300;
  }

  if (result_f < TargetAngleHvataljka + 1 && result_f > TargetAngleHvataljka - 1 )
  {
    p_f = TargetAngleHvataljka;
  }

  k_f = TargetAngleHvataljka;
  o_f = abs(p_f - k_f);
  d_f= o_f * 500;

  //Formula of Sigmoid Func which I tweaked in Desmos graph, so I can manipulate end point, start point and stretch of func:
  //
  result_f = ( (k_f - p_f) * pow(2.71828, b_f * delta_time_f) ) / (pow(2.71828, b_f * delta_time_f) + d_f) + p_f;
  delta_time_f = delta_time_f + 5 ;

  servoHvataljka.writeMicroseconds(result_f);
  Serial.println(result_f);

}



void Fx_tSerial() {

 //Checking serial bus for angle data
  int SerAvailalbe = Serial.available();
  if ( SerAvailalbe > 0)
  {
    String TempData = Serial.readString();  //read until timeout
    TempData.trim();
    //TargetAnglePlatforma = GetUgao(&TempData, 'a'));

    String chunk = "";
    for (int i = 0; i < TempData.length(); i++)
    {
      char m = TempData[i];
      if (m == '/')
      {

        int angle =  chunk.toInt();
        if (angle >= 0)
        {
          //Check which motor to affect
          if (chunk.indexOf('a') >= 0)
          {
            p_a = result_a;
            TargetAnglePlatforma = angle * 11.11 + 500;
            delta_time_a = 0;                
          }

          else if (chunk.indexOf('b') >= 0)
          {
            p_b = result_b;
            TargetAngleZglob1 = angle * 11.11 + 500;
            delta_time_b = 0;
          }

          else if (chunk.indexOf('c') >= 0)
          {
            p_c = result_c;
            delta_time_c = 0;
            TargetAngleZglob2 = angle * 11.11 + 500;
          }

          else if (chunk.indexOf('d') >= 0)
          {
            p_d = result_d;
            delta_time_d = 0;
            TargetAngleZglob3 = angle * 11.11 + 500;
          }
          
          else if (chunk.indexOf('e') >= 0)
          {
            p_e = result_e;
            delta_time_e = 0;
            TargetAngleRot = angle * 11.11 + 500;
          }

           else if (chunk.indexOf('f') >= 0)
          {
            p_f = result_f;
            delta_time_f = 0;
            TargetAngleHvataljka = angle * 11.11 + 500;
          }
          
          chunk = "";
        }
      }
      else
      {
        chunk += m;
      }

    }

  }
}

void Fx_Tester()
{

}


//Tasks
Task tester(500, TASK_FOREVER, &Fx_Tester);

Task tSerial(1, TASK_FOREVER, &Fx_tSerial);
Task tPlatforma(50, TASK_FOREVER, &Fx_Platforma);
Task tZglob1(50, TASK_FOREVER, &Fx_Zglob1);
Task tZglob2(50, TASK_FOREVER, &Fx_Zglob2);
Task tZglob3(50, TASK_FOREVER, &Fx_Zglob3);
Task tRot(50, TASK_FOREVER, &Fx_Rot);
Task tHvataljka(50, TASK_FOREVER, &Fx_Hvataljka);

Scheduler runner;

void setup () {
  Serial.begin(9600);
  
  servoPlatforma.attach(3);
  servoZglob1.attach(5);
  servoZglob2.attach(6);
  servoZglob3.attach(9);
  servoRot.attach(10);
  servoHvataljka.attach(11);

  runner.init();

  runner.addTask(tester);

  runner.addTask(tZglob1);
  runner.addTask(tPlatforma);
  runner.addTask(tSerial);
  runner.addTask(tZglob2);
  runner.addTask(tZglob3);
  runner.addTask(tRot);
  runner.addTask(tHvataljka);
    
  tester.enable();
  tSerial.enable();
  tPlatforma.enable();
  tZglob1.enable();
  tZglob2.enable();
  tZglob3.enable();
  tRot.enable();
  tHvataljka.enable();
}


void loop () {
  runner.execute();
}
