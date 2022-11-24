using System;

class Program{
    public static void Main(string[] args)
    {
        int num=0;
        char check = 's';
        char flower = 'x';
        
    }  

    public void Flower_check(char check, char flower){
        Queue<char>set = new Queue<char>();
        flower= char.Parse(Console.ReadLine());
        //J==มะลิG==บานไม่รู้โรยห้ามติดเกิน3,O==กล้วยไม้R==กุหลาบอยู่ระหว่างที่ต่างกัน

        
        while (flower == 'J' || flower == 'G' || flower =='O' || flower == 'R'){
            if (flower == 'J'){
                if(check == flower){
                    Console.WriteLine("invailid pattern.");
                    check = 'J';
                }
                else{
                    set.Push(flower);
                    check = 's';

                }
            }
            else if(flower == 'O'){
                if(check == flower){
                    Console.WriteLine("invailid pattern.");
                    check = 'O';
                }
                else{
                    set.Push(flower);
                    check = 's';

                }
            }
            else if(flower == 'G'){
                if(check == flower){
                    Console.WriteLine("invailid pattern.");
                    check = 'G';
                }
                else{
                    set.Push(flower);
                    check = 's';

                }
            }
            else if(flower == 'R'){
                if(check == flower){
                    Console.WriteLine("invailid pattern.");
                    check = 'R';
                }
                else{
                    set.Push(flower);
                    check = 's';

                }
            }
        }

    
        for (int i = 0; i< set.GetLength(); i++){
            Console.WriteLine("{0}",set.Get(i));
        }
        
        
    }

    
    
    
}