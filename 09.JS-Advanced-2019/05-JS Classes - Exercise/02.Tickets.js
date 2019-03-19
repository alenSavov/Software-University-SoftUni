function solve(inputArr, sortCriteria){
    class Ticket{
        constructor(destination, price, status){
            this.destination = destination;
            this.price = price;
            this.status = status;
        }
    }

    let tickets = [];

    Array.from(inputArr).forEach((line) => {
        let info = line.split("|");

        let dest = info[0];
        let price = parseFloat(info[1]);
        let status = info[2];

        let ticket = new Ticket(dest, price, status);
        tickets.push(ticket);
    });
    function sortTickets(criteria, tickets){
        let tempTickets = tickets.slice(0);

        tempTickets = Array.from(tempTickets).sort((a, b) => compareTicketByProperties(a[sortCriteria],b[criteria]));

        return tempTickets;
    }

    function compareTicketByProperties(a, b){
        if(a > b){
            return 1;
        } else if(a === b){
            return 0;
        } else {
            return -1;
        }
    }

    tickets = sortTickets(sortCriteria, tickets);

    return tickets;
}

solve(
    ['Philadelphia|94.20|available',
        'New York City|95.99|available',
        'New York City|95.99|sold',
        'Boston|126.20|departed'],
    'status'
)