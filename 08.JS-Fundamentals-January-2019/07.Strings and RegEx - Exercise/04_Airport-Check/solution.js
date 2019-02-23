function solve() {
    let input = document.getElementById('str');
    let resultElement = document.getElementById('result');

    let patternCompany = /(- [A-Za-z]+\*[A-Za-z]+ )/;
    let patternNames = /( [A-Za-z]+[-]{1}[A-Za-z]+ )|( [A-Za-z]+[-]{1}[A-Za-z]+.[-]{1}[A-Za-z]+ )/g;
    let patternAirport = /( [A-Z]{3}[\/]{1}[A-Z]{3} )/;
    let patternFlightNumber = /( [A-Z]{1,3}[0-9]{1,5} )/

    let parameter = input.value.split(', ')[1];

    if (parameter === 'all') {
        let tokens = getAllTokens(input, patternFlightNumber, patternAirport, patternCompany);
        tokens.forEach(t => t.trim());
        resultElement.textContent = `Mr/Ms, ${tokens[0]}, your flight number ${tokens[1]} is from ${tokens[2]} to ${tokens[3]}. Have a nice flight with ${tokens[4]}.`;
    }
    else if (parameter === 'flight') {
       let flightNumber = getFlightNumber(input, patternFlightNumber);
       let airportTokens = getAirportTokens(input,patternAirport);
       airportTokens.forEach(t => t.trim());
       resultElement.textContent = `Your flight number ${flightNumber} is from ${airportTokens[0].trim()} to ${airportTokens[1].trim()}.`;
    }
    else if (parameter === 'name') {
        let names = getNames(input, patternNames);
        resultElement.textContent = `Mr/Ms, ${names}, have a nice flight!`;
    }
    else if (parameter === 'company') {
      let company = getCompany(input, patternCompany);
      resultElement.textContent = `Have a nice flight with ${company}.`;
    }

    function getNames(input, patternNames) {
        let match = patternNames.exec(input.value);
        let names;

        if (match[1] != undefined) {
            names = replaceDasheshWithSpace(match[1]);
        } else {
            let names = replaceDasheshWithSpace(match[2]);
        }

        return names.trim();
    }

    function getAirportTokens(input, patternAirport) {
        return patternAirport.exec(input.value)[1].split('/');
    }

    function getAllTokens(input, patternFlightNumber, patternAirport, patternCompany) {
        let namesTokens = getNames(input, patternNames);
        let names = replaceDasheshWithSpace(namesTokens);

        let flightNumber = getFlightNumber(input, patternFlightNumber);

        let airportTokens = getAirportTokens(input, patternAirport);
        let fromAirport = airportTokens[0].trim();
        let toAirport = airportTokens[1].trim();

        let company = getCompany(input, patternCompany);

        let tokens = [];
        tokens.push(names, flightNumber, fromAirport, toAirport, company);
        return tokens;
    }

    function getCompany(input, patternCompany) {
        let companyTokens = patternCompany.exec(input.value)[1];
        return company = removeDashesAndStarts(companyTokens);
    }

    function getFlightNumber(input, patternFlightNumber) {
        return patternFlightNumber.exec(input.value)[1].trim();
    }

    function replaceDasheshWithSpace(input) {
        return (input.replace(/-/g, ' '));
    }

    function removeDashesAndStarts(input) {
        return input.replace(/[-*]/g, ' ').trim();
    }
}

