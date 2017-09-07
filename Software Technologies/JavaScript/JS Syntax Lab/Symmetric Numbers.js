function solve(input) {
    let number = input.filter(e => e);

    for(let i = 1; i <= Number(number);i++){
        let numberStr = i.toString();
        if(numberStr.length === 1)
        {
            console.log(i + " ");
            continue;
        }
        if(numberStr === numberStr.split("").reverse().join(""))
            console.log(i + " ");

    }
}

