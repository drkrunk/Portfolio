import { Ticket } from './ticket';

export class Account {
    id:bigint;
    email:string;
    roleId:number;
    userName:string;
    pins:Array<Ticket>;
}