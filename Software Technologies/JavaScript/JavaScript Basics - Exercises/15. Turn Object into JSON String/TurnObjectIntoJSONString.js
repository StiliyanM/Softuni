function solve(input) {

    let obj = {};

    input.map(a => a.split(" -> "))
        .forEach(tokens =>
        {
            let property = tokens[0];
            let value = isNaN(tokens[1]) ? tokens[1] : Number(tokens[1]);

            obj[property] = value;
        }
        )
    ;

    console.log(JSON.stringify(obj));
}

let input =  [
    'name -> Angel',
    'surname -> Georgiev',
    'age -> 20',
    'grade -> 6.00',
    'date -> 23/05/1995',
    'town -> Sofia'
];

solve(input);