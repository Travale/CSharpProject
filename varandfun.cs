using System;

public class NewVariables {

    int newInt = 10;

    void First(){
        newInt = AddByThree(newInt);
    }
    int AddByThree(int thisNumber){
        int ret;

        ret = thisNumber + 3;

        return ret;
    }
}

 /* variables are like corrals.  You need a different type of corral for each type of animal or in the case of programming informtion.
The int variable is used to hold an integer.  If you want to do something with the integer you
put it in a function.  You can add an integer together with another integer inside the function.
Create a function with parameters in brackets () to guide it. Call a function inside of another function
so you can run a new variable through the first function. */