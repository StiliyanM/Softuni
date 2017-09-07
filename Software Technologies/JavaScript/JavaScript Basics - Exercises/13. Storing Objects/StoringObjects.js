function storingObjects(input) {

    let studets = [];
    let counter = 0;

    for (let line of input) {
        let tokens = line.split(" -> ");
        let name = tokens[0];
        let age = Number(tokens[1]);
        let grade = Number(tokens[2]);

        let student = {
            Name: name,
            Age: age,
            Grade: grade
        };

        studets[counter] = student;
        counter++;
    }

    for (let index = 0; index < studets.length; index++) {
        console.log(`Name: ${studets[index].Name}`);
        console.log(`Age: ${studets[index].Age}`);
        console.log(`Grade: ${studets[index].Grade.toFixed(2)}`);
    }
}

let input = [
    'Pesho -> 13 -> 6.00',
    'Ivan -> 12 -> 5.57',
    'Toni -> 13 -> 4.90'
];

storingObjects(input);