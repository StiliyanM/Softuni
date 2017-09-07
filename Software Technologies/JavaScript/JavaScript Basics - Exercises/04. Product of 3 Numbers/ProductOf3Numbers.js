function ProductOf3Numbers(arr) {
    let numbers = arr.map(Number);

    let counter = 0;
    for (let num of numbers) {
        if (num == 0) {
            console.log("Positive");
            return;
        }
        else if (num < 0) {
            counter++;
        }
    }

    if (counter % 2 == 0) {
        console.log("Positive");
    }
    else {
        console.log("Negative")
    }
}