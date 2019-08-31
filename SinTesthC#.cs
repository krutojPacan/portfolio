using System;

class MainClass {
  public static void Main (string[] args) {
    var t = new myClass();
    float angle = 0;
    int sinM;
    float sinn;
    t.clear();
    while(true){
      for(int x = 0; x < 60; x++){
        angle += 0.1f;
        sinn = (float)Math.Sin(angle);
        sinM = (int)Math.Floor(sinn.Remap(-1f, 1f, 1f, 10f));
        //System.Threading.Thread.Sleep(10);
        t.writePos(x, sinM, "#");
      }
      System.Threading.Thread.Sleep(200);
      t.clear();
    }
  }
}
public static class ExtensionMethods {
 
public static float Remap (this float value, float from1, float to1, float from2, float to2) {
    return (value - from1) / (to1 - from1) * (to2 - from2) + from2;
}
   
}
class myClass {
  public void  writePos(int x, int y, string text){
    Console.SetCursorPosition(x, y);
    Console.Write(text);
  }
  public void clear(){
    for(int x = 0; x < 60; x++){
      for(int y = 0; y < 10; y++){
        writePos(x, y, " ");
      }
    }
  }
  //public float map(float s, float a1, float a2, float b1, float b2){
  //  return b1 + (s-a1)*(b2-b1)/(a2-a1);
  //}
}
