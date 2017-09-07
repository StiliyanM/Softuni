function PrintLines(input) {
    for (let i of input) {
        if (i == "Stop") {
            return;
        }
        else {
            console.log(i)
        }
    }
}
