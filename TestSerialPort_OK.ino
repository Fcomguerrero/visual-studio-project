/***********************************
 ARDUINO DUEMILANOVE DIECIMILA (Arduino Pequeño)
LCD 1.3 OLED IIC SDA->A4 SCL->A5 VCC=3.3v
************************************/
#include "U8glib.h"
U8GLIB_SH1106_128X64 u8g(U8G_I2C_OPT_NONE);

int cont=0;
String datorecibido="";
//******************************Funcion**************************************
void draw(String txt) {
  u8g.setFont(u8g_font_profont12);
  u8g.setPrintPos(0, 10);
  u8g.print(txt);
}
//******************************Setup**************************************
void setup(){
  //iniciamos el puerto serie
  Serial.begin(9600);
//----- Initialize the lcd -
     u8g.firstPage();
  do {
    draw("");
  } while (u8g.nextPage() );   
}
//*****************************Loop*****************************************
void loop(){
  
  if(Serial.available()>0)
  {   
     //Comprobamos si en el buffer hay datos
    do{
      char dato=Serial.read();  //Lee cada carácter uno por uno y se almacena en una variable  
      //Suma de caracteres en variable string
      datorecibido+=dato;              
    }while(Serial.available()>0);
    //----------------------- 
    u8g.firstPage();
    do {
    draw(datorecibido);
    } while (u8g.nextPage() );
    delay(1500);
    datorecibido="";      //ARDUINO DUEMILANOVE DIECIMILA
    u8g.firstPage();      //LCD 1.3 OLED IIC SDA->A4 SCL->A5 
    do {
    draw(datorecibido);
    } while (u8g.nextPage() );
    //---------------------------
  }
//----------------------------------------------------------
  //Imprimimos el valor del contador
  Serial.print("Envio desde Arduino: ");
  Serial.println(cont);
  //incrementamos el contador y esperamos un segundo
  cont++;
  if(cont>99999)
    cont=0;
    
  delay(1000);
}
//**********************************************************************
