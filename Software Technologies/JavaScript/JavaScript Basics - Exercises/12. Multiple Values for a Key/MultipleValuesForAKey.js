function MultipleValuesForAKey(input) {

    function parseKeyValuesPairs(str) {
        let tokens = str.split(' ');
        let result = {
            key: tokens[0],
            value: tokens[1]
        };

        return result;
    }

    let searchedKey = input[input.length - 1];
    let keyValuesPairs = input.slice(0, -1)
        .map(parseKeyValuesPairs);

    let dict = {};

    keyValuesPairs.forEach(element => {
        if (!dict[element.key]) {
            dict[element.key] = [];
        }

        dict[element.key].push(element.value);
    })

    if (dict[searchedKey]) {
        for (let i = 0; i < dict[searchedKey].length; i++) {
            console.log(dict[searchedKey][i]);
        }
    }
    else {
        console.log("None")
    }
}

let input = [
    'key value',
    'key eulav',
    'test tset',
    'key'
];

MultipleValuesForAKey(input);
