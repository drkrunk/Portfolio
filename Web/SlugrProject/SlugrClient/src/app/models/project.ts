import {Account} from './account';
import { Ticket } from './ticket';

export class Project{
    id:bigint;
    ownerId:bigint;
    projectDescription:string;
    projectName:string;
    publicProject:boolean;
    team:Array<Account>;
    tickets:Array<Ticket>;

}