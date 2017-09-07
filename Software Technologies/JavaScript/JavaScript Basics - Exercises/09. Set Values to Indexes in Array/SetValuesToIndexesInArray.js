function SetValuesToIndexesInArray(arr) {
    let length = Number(arr[0]);
    let array = new Array(length);

    for(let i = 0; i < array.length; i++) {
        array[i] = 0;
    }

   let indexElementPairs = arr.slice(1);

    for(let i = 0; i < indexElementPairs.length; i++) {
        let tokens = indexElementPairs[i].split(' - ').map(Number);

        let [index, value] = tokens;

        array[index] = value;
    }

    for(let i = 0; i < array.length; i++) {
        console.log(array[i]);
    }
}
