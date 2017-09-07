function solve([input]) {
    [num1,num2,num3] = input.split(" ").map(Number);

    if(num1 === num2 + num3)
    {
        console.log(Math.min(num2,num3) + " + " + Math.max(num2,num3) + " = " + num1);
    }
    else if(num2 === num1 + num3)
    {
        console.log(Math.min(num1,num3) + " + " + Math.max(num1,num3) + " = " + num2);
    }
    else if(num3 === num1 + num2)
    {
        console.log(Math.min(num1,num2) + " + " + Math.max(num1,num2) + " = " + num3);
    }
    else
    {
        console.log("No");
    }
}