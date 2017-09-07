function solve(input) {
  console.log(input.map(Number).
  sort((x,y) => y - x).
  slice(0,3).
  join("\n"));
}

