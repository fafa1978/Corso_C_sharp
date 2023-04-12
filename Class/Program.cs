using System;
namespace Class
{
    public class MyClass
    {
        string MyString="Hello";
        // int MyInt;


        static void Main(string[] args){
            int z =Somma(10,5);
            Console.WriteLine(z);
        }

        static int Somma(int x, int y)
        {
            int s = x + y;
            return s;
        }
        public string getMyString(){
          return MyString;
        }
      
         public void setMyString(string s){
           MyString = s;
           
         }
    }    
}
