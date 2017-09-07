function AddOrRemoveElements(arr) {

    let list = [];

    for(let tokens of arr) {
        let token = tokens.split(" ");
        let command = token[0];
        let number = Number(token[1]);

        if (command == "add") {
            list.push(number);
        }
        else {
            if (number >= list.length) {
                continue;
            }
            else {
                list.splice(number, 1);
            }
        }
    }

    for(let i = 0; i < list.length; i++) {
        console.log(list[i]);
    }
}
