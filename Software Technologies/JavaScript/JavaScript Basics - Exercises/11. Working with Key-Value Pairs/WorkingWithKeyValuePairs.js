function WorkingWithKeyValuePairs(input) {

    function parseArray(str) {
        let tokens = str.split(" ");
        let result = {
            key: tokens[0],
            value: tokens[1]
        };

        return result;
    }

    let dict = {};

    let searchKey = input[input.length - 1];
    let array = input.slice(0, -1)
        .map(parseArray);

    array.forEach(element => {
        if (!dict[element.key]) {
            dict[element.key] = element.value;
        }
        else {
            dict[element.key] = element.value;
        }
    })

    if (dict[searchKey] != undefined) {
        console.log(dict[searchKey]);
    }
    else {
        console.log("None")
    }
}

input = [
    'key value',
    'key eulav',
    'test tset',
    'test'

];

WorkingWithKeyValuePairs(input);