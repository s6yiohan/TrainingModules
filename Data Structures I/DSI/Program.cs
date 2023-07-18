using System;


public class TowerOfHanoi{

    static int[] A = new int[3]{1,2,3};
    static int[] B = new int[3]{1,2,3};
    static int[] C = new int[3]{0,0,0};

    public static void Main(){
        Console.WriteLine("TOWER OF HANOI");

        Console.Write("A");
        foreach(int i in A){
            Console.Write("{0}", i);
        }

        Console.Write("\nB");
        foreach(int i in B){
            Console.Write("{0}", i);
        }
        
        Console.Write("\nC");
        foreach(int i in C){
            Console.Write("{0}", i);
        }    

        CommandInput();

    }

    //Reads user input
    static void CommandInput(){
        Console.WriteLine("\nEnter Command: ");
        Console.Write("=> ");
        string command = Console.ReadLine();
        CommandSwitch(command);
    }

    //Takes in the user input to check which function to use
    static void CommandSwitch(string command){
        switch(command){
            case "RESTART":{
                Restart(A,B,C);
                break;
            }

            case "MOVE A B":{
                MoveStackRing("A", A, "B", B);
                CommandInput();
                break;
            }

            case "MOVE A C":{
                MoveStackRing("A", A, "C", C);
                CommandInput();
                break;
            }

            case "MOVE B A":{
                MoveStackRing("B", B, "A", A);
                CommandInput();
                break;
            }

            case "MOVE B C":{
                MoveStackRing("B", B, "C", C);
                CommandInput();
                break;
            }

            case "MOVE C A":{
                MoveStackRing("C", C, "A", A);
                CommandInput();
                break;
            }

            case "MOVE C B":{
                MoveStackRing("C", C, "B", B);
                CommandInput();
                break;
            }
            

            default: {
                Console.WriteLine("ERROR COMMAND NOT FOUND! Please use one of the following commands:");
                Console.WriteLine("RESTART : Restarts the game");
                Console.WriteLine("MOVE X Y : Substitute X for the name of the stack to take from. Substitute Y for the name of the stack to be added to.");
                break;
            }
        }
    }


    static void Restart(int[] A, int[] B, int[] C){
        A = new int[3]{1,2,3};
        B = new int[3]{1,2,3};
        C = new int[3]{0,0,0};

        Console.WriteLine("Game Restarted! \n");

        Console.Write("A");
        foreach(int i in A){
            Console.Write("{0}", i);
        }

        Console.Write("\nB");
        foreach(int i in B){
            Console.Write("{0}", i);
        }
        
        Console.Write("\nC");
        foreach(int i in C){
            Console.Write("{0}", i);
        }

        CommandInput();
    }

    static void MoveStackRing(string stack1Name, int[] stack1, string stack2Name, int[] stack2)
    {
        //Checks if Stack 2 is full
        if(!stack2.Contains(0)){
            Console.Write("ERROR: Stack {0} is full! {0}", stack2Name);
            
            foreach(int i in stack2){
                Console.Write("{0}", i);
            }

            Console.WriteLine("\n");

            return;
        }

        //Checks if Stack 1 is empty
        int var = 0;
        foreach(int i in stack1){
            var += i;
        }

        if(var == 0){
            Console.Write("ERROR: Stack {0} is empty! {0}", stack1Name);
            
            foreach(int i in stack1){
                Console.Write("{0}", i);
            }

            Console.WriteLine("\n");

            return;
        }

        //Pops ring from stack1 and pushes ring to stack2
        int ring = 0;
        for(int i = 0; i < stack1.Length; i++){
            if(stack1[i] != 0){
                ring = stack1[i];
                stack1[i] = 0;
                break;
            }
        }

        for(int i = stack2.Length-1; i > 0; i--){
            if(stack2[i] == 0){
                stack2[i] = ring;
                break;
            }
        }

        Console.Write("SUCCESS: Moved ring {0} from Stack {1} to Stack {2}", ring, stack1Name, stack2Name);
        Console.Write("\n{0}", stack1Name); 
        foreach(int i in stack1){
            Console.Write("{0}", i);
        }
        Console.Write(" {0}", stack2Name); 
        foreach(int i in stack2){
            Console.Write("{0}", i);
        }
        Console.WriteLine("");
        return;


    }
}

