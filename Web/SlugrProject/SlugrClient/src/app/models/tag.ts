import { Ticket } from './ticket';

export class Tag{

    id:bigint;
    ticket:Ticket;
    text:String;

    constructor(t:string){this.text = t;}

}