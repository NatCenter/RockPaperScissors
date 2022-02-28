using System;
using System.Collections.Generic;











int playerInput()
{

    List<string> RockPaperScissors = new List<string>();
    RockPaperScissors.Add("");
    RockPaperScissors.Add("Rock");
    RockPaperScissors.Add("Paper");
    RockPaperScissors.Add("Scissors");


    Console.WriteLine("What would you like to throw?");
    Console.Write("1)" + RockPaperScissors[1]);
    Console.WriteLine();
    Console.Write("2)" + RockPaperScissors[2]);
    Console.WriteLine();
    Console.Write("3)" + RockPaperScissors[3]);
    Console.WriteLine("");
    int userNumber = int.Parse(Console.ReadLine());
    if (userNumber == 1)
    {
        Console.Write(@"
  _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)
");
    }
    if (userNumber == 2)
    {
        Console.Write(@"
     _______
---'    ____)____
           ______)
          _______)
         _______)
---.__________)
    ");
    }
    if (userNumber == 3)
    {
        Console.Write(@"
      _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)
    ");
    }

    return userNumber;


}


Console.WriteLine("");

int computerInput()
{

    Console.WriteLine();
    Console.Write("VS");

    List<string> ComputerRockPaperScissors = new List<string>();
     ComputerRockPaperScissors.Add("");
    ComputerRockPaperScissors.Add(@"
    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)
    
    ");
    ComputerRockPaperScissors.Add(@"
    _______
---'    ____)____
           ______)
          _______)
         _______)
---.__________)
    ");
    ComputerRockPaperScissors.Add(@"     
    _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)");
    Random computerNumber = new Random();
    int randomComputerNumber = computerNumber.Next(1, 3);
    
    
    Console.WriteLine(ComputerRockPaperScissors[randomComputerNumber]);
    return randomComputerNumber;

}
   
    int playerPoint=0;
    int computerPoint=0;
void passVaules(int playerDraw, int computerDraw)
{
    
    
       
    //if the player picks paper and the computer picks rock
      
      if (playerDraw == 2 &&  computerDraw==1){

        playerPoint++;
        
    }
    
    
    // if the player picks Scissors and the computer picks rock
        if (playerDraw == 3 &&  computerDraw==1){

        playerPoint++;
        
            }

    //if the player picks rock and  the computer picks paper 
    if (playerDraw == 1 &&  computerDraw==2){
         computerPoint++;
            }
    // if the player picks Scissors and the computer picks paper
    if (playerDraw == 3 &&  computerDraw==2){

        playerPoint++;
       
            }

        //if the player picks rock and the computer picks Scissors
    if (playerDraw==1 && computerDraw==3){
          playerPoint++;
        
    }

    // if the player picks paper and the computer picks Scissors
     if (playerDraw == 2 &&  computerDraw==3){
        computerPoint++;
            }

    // if the player picks the same as the computer etc paper and paper,rock and rock, Scissors and Scissors
    if (playerDraw == computerDraw)
    {
        Console.WriteLine(" Draw!");
        
       

    }
    
   


}

  
void rounds()


{
   
  
    int i = 1;
passVaules(playerInput(), computerInput());
   
    do 
    {
        Console.WriteLine(@$"
    ------------------------
     | Player:{playerPoint} | Computer:{computerPoint} |
    -------------------------
          
     ");
        passVaules(playerInput(), computerInput());
        playerInput();
        computerInput();




        i++;

    
    } while (i < 4);

   

if(playerPoint > computerPoint){
        Console.Write("you win!");

    }
     if (playerPoint<computerPoint) {
        Console.Write("you lose!");
    }
 if(computerPoint==playerPoint){
        Console.Write("it is a draw!");

    }
     Console.WriteLine(@$"
    ------------------------
     | Player:{playerPoint} | Computer:{computerPoint} |
    
          
     ");
}

rounds();



