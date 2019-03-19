function solve(arr, command) {
  let ascedingComparator = function (a, b) {
      return a - b;
  };

  let descendingComparator = function (a, b) {
      return b - a;
  };

  let sortiongStrategies = {
      'asc': ascedingComparator,
      'desc': descendingComparator
  };

  return arr.sort(sortiongStrategies[command]);
}

console.log(solve([14, 7, 17, 6, 8], 'desc'));